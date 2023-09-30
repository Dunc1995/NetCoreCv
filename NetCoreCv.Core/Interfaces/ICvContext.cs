using Microsoft.EntityFrameworkCore;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Interfaces;
public interface ICvContext
{
    public DbSet<Project> Projects { get; set; }

    public DbSet<WorkExperience> WorkExperiences { get; set; }
}
