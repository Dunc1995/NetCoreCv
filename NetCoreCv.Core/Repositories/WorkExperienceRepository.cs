using Microsoft.EntityFrameworkCore;
using NetCoreCv.Core.Interfaces;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Repositories;
public class WorkExperienceRepository : CvRepository<WorkExperience>
{
    public WorkExperienceRepository(CvContext context) : base(context)
    {

    }
}
