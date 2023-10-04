using NetCoreCv.Core.Models;

namespace NetCoreCv.WebApp.ViewModels;

public class ProjectViewModel
{
    public int ProjectId { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public ProjectViewModel()
    {

    }

    public static explicit operator ProjectViewModel(Project project) => new()
    {
        ProjectId = project.ProjectId,
        Title = project.Title,
        Description = project.Description
    };

    public static explicit operator Project(ProjectViewModel project) => new()
    {
        ProjectId = project.ProjectId,
        Title = project.Title,
        Description = project.Description
    };
}
