using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv;
public class ProjectController : CrudController<Project, ProjectRepository>
{
    public ProjectController(ProjectRepository context) : base(context)
    {

    }

    public async Task<IActionResult> Index()
    {
        return View((await _context.GetAllAsync()).Select(x => (ProjectViewModel)x));
    }
}
