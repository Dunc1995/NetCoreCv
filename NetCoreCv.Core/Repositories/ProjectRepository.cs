using Microsoft.EntityFrameworkCore;
using NetCoreCv.Core.Interfaces;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Repositories;
public class ProjectRepository : IRepository<Project>
{
    private readonly ICvContext _context;

    public ProjectRepository(ICvContext context) {
        _context = context;
    }

    public async Task<IEnumerable<Project>> GetAllAsync() {
        return await _context.Projects.ToListAsync();
    }
}
