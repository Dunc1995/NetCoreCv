using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv;
public class ProjectController : CrudController<ProjectViewModel, ProjectRepository, Project>
{
    public ProjectController(ProjectRepository context) : base(context) {
        
    }
}
