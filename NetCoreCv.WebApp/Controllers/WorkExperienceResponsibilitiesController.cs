using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv.WebApp.Controllers;

public class WorkExperienceResponsibilitiesController : 
    CrudController<WorkExperienceResponsibilityViewModel, WorkExperienceResponsibility, WorkExperienceResponsibilitiesRepository>
{
    private readonly WorkExperienceRepository _workExperienceContext;

    public WorkExperienceResponsibilitiesController(WorkExperienceRepository workExperienceContext, WorkExperienceResponsibilitiesRepository context) : base(context)
    {
        _workExperienceContext = workExperienceContext;
    }

    [Route("WorkExperience/Edit/{id}/WorkExperienceResponsibilities")]
    public async Task<IActionResult> Index(int id) {
        var workExperience = await _workExperienceContext.GetAsync(id);

        if (workExperience == null)
            return NotFound();
        
        var responsibilities = (await _context.GetAllAsync())
            .Where(x => x.WorkExperienceId == id)
            .Select(x => (WorkExperienceResponsibilityViewModel)x);
        
        var vm = new WorkExperienceResponsibilitiesViewModel()
        {
            JobTitle = workExperience.JobTitle,
            Responsibilities = responsibilities
        };

        return View(vm);
    }

    [Route("WorkExperience/Edit/{id}/WorkExperienceResponsibilities/Edit")]
    [Route("WorkExperience/Edit/{id}/WorkExperienceResponsibilities/Edit/{rid}")]
    public Task<IActionResult> Edit(int id, int? rid ) {
        return base.Edit(rid);
    }
}
