using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Repositories;
public class CvRepository
{
    public async Task LoadEntities<T>(int id, T obj) where T : class
    {
        switch (obj)
        {
            case CurriculumVitae curriculumVitae:
                await _context.CurriculumVitaes
                        .Include(x => x.WorkExperience)
                            .ThenInclude(x => x.Company)
                        .Include(x => x.WorkExperience)
                            .ThenInclude(x => x.Address).FirstOrDefaultAsync(x => x.CurriculumVitaeId == id);
                break;
            default:
                break;
        }
    }

    private protected readonly CvContext _context;

    public CvRepository(CvContext context)
    {
        _context = context;
    }

    public virtual async Task<T?> GetAsync<T>(int workExperienceId) where T : class
    {
        var data = await _context.FindAsync<T>(workExperienceId);

        if (data != null) {
            await LoadEntities(workExperienceId, data);
        }

        return data;
    }

    public async Task DeleteAsync<T>(int id) where T : class
    {
        var item = await _context.FindAsync<T>(id);

        if (item != null)
        {
            _context.Remove(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task PutAsync<T>(int id, T item) where T : class
    {
        var result = await _context.FindAsync<T>(id);

        if (result == null)
        {
            await _context.AddAsync(item);
        }
        else
        {
            _context.Entry(result).State = EntityState.Detached;

            _context.Update(item);
        }

        await _context.SaveChangesAsync();
    }
}
