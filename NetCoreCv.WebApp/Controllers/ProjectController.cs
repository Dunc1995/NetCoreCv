using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv.WebApp.Controllers;

public class ProjectController : CrudController<ProjectViewModel, Project, ProjectRepository>
{
    public ProjectController(ProjectRepository context) : base(context)
    {

    }
}
