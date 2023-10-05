using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv.WebApp.Controllers;
public class WorkExperienceController : CrudController<WorkExperienceViewModel, WorkExperience, WorkExperienceRepository>
{
    private readonly ILogger<WorkExperienceController> _logger;

    public WorkExperienceController(WorkExperienceRepository context, ILogger<WorkExperienceController> logger) : base(context)
    {
        _logger = logger;
    }
}
