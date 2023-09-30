using Microsoft.EntityFrameworkCore;
using NetCoreCv.Core.Interfaces;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Repositories;
public class WorkExperienceRepository : IRepository<WorkExperience>
{
    private readonly ICvContext _context;

    public WorkExperienceRepository(ICvContext context) {
        _context = context;
    }

    public async Task<IEnumerable<WorkExperience>> GetAllAsync() {
        return await _context.WorkExperiences.ToListAsync();
    }
}
