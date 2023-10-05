using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;

namespace NetCoreCv.Core.Repositories;
public class WorkExperienceResponsibilitiesRepository : CvRepository<WorkExperienceResponsibility>
{
    public WorkExperienceResponsibilitiesRepository(CvContext context) : base(context)
    {

    }
}
