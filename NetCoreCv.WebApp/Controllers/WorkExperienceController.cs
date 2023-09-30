using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv;
public class WorkExperienceController : CrudController<WorkExperience, WorkExperienceRepository>
{
    public WorkExperienceController(WorkExperienceRepository context) : base(context) {
        
    }

    public async Task<IActionResult> Index() {
        return View((await _context.GetAllAsync()).Select(x => (WorkExperienceViewModel)x));
    }
}
