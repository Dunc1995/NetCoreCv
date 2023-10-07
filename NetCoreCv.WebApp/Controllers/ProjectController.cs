using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.Schemas;

namespace NetCoreCv.WebApp.Controllers;

public class ProjectController : CrudController<ProjectSchema, Project>
{
    public ProjectController(CvRepository context) : base(context)
    {

    }
}
