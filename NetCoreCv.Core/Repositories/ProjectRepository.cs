using Microsoft.EntityFrameworkCore;
using NetCoreCv.Core.Interfaces;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Repositories;

public class ProjectRepository : CvRepository<Project>
{
    public ProjectRepository(CvContext context) : base(context)
    {

    }
}
