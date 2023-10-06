using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
namespace NetCoreCv.WebApp.Controllers;

public class ProjectController : CrudController<Project>
{
    public ProjectController(CvRepository context) : base(context)
    {

    }
}
