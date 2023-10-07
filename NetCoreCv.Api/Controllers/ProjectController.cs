using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.Api.Schemas;

namespace NetCoreCv.Api.Controllers;

public class ProjectController : CrudController<ProjectSchema, Project>
{
    public ProjectController(CvRepository context) : base(context)
    {

    }
}
