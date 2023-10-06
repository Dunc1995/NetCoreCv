using Microsoft.EntityFrameworkCore;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Repositories;
public class CvRepository
{
    private protected readonly CvContext _context;

    public CvRepository(CvContext context)
    {
        _context = context;
    }

    public virtual async Task<T?> GetAsync<T>(int workExperienceId) where T : class
    {
        return await _context.FindAsync<T>(workExperienceId);
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

    public async Task PutAsync<T>(T item) where T : class
    {
        var result = await _context.FindAsync<T>(item);

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
