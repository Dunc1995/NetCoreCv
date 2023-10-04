using Microsoft.EntityFrameworkCore;
using NetCoreCv.Core.Interfaces;
using NetCoreCv.Core.Repositories;

namespace NetCoreCv.Core;
public class CvRepository<T> : IRepository<T> where T : class, IModel
{
    private readonly CvContext _context;

    public CvRepository(CvContext context)
    {
        _context = context;
    }

    public async Task<T?> GetAsync(int workExperienceId)
    {
        return await _context.FindAsync<T>(workExperienceId);
    }

    public async Task DeleteAsync(int id)
    {
        var item = await _context.FindAsync<T>(id);

        if (item != null)
        {
            _context.Remove(item);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task PutAsync(T item)
    {
        var result = await _context.FindAsync<T>(item.Id);

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
