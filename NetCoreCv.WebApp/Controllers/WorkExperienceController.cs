using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv;
public class WorkExperienceController : CrudController<WorkExperience, WorkExperienceRepository>
{
    private readonly ILogger<WorkExperienceController> _logger;

    public WorkExperienceController(WorkExperienceRepository context, ILogger<WorkExperienceController> logger) : base(context)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        _logger.LogDebug("Testing testing");

        return View((await _context.GetAllAsync()).Select(x => (WorkExperienceViewModel)x));
    }

    [HttpPut]
    public async Task<IActionResult> Edit([FromBody]WorkExperienceViewModel model)
    {
        var _model = (WorkExperience)model;

        _logger.LogDebug("Data received:", _model);        

        await _context.PutAsync(_model);

        return Ok();
    }

    [HttpGet]
    [Route("WorkExperience/Edit")]
    [Route("WorkExperience/Edit/{workExperienceId}")]
    public async Task<IActionResult> Edit(int? workExperienceId)
    {
        var model = new WorkExperienceViewModel();

        if (workExperienceId != null) {
            var result = await _context.GetAsync((int)workExperienceId);

            if (result != null) {
                model = (WorkExperienceViewModel)result;
            }
        }

        return View(model);
    }
}
