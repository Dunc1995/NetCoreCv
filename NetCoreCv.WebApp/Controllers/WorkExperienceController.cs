using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv;
public class WorkExperienceController : CrudController<WorkExperienceViewModel, WorkExperienceRepository, WorkExperience>
{
    public WorkExperienceController(WorkExperienceRepository context) : base(context) {
        
    }
}
