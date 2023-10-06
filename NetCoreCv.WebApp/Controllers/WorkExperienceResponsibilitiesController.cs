using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;

namespace NetCoreCv.WebApp.Controllers;

public class WorkExperienceResponsibilitiesController : CrudController<Responsibility>
{
    public WorkExperienceResponsibilitiesController(CvRepository context) : base(context)
    {

    }
}
