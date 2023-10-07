using NetCoreCv.Core.Models;
using NetCoreCv.WebApp.Interfaces;

namespace NetCoreCv.WebApp.Schemas;
public class ProjectSchema : ISchema<ProjectSchema, Project>
{
    public int Id => ProjectId;

    public int ProjectId { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public ProjectSchema()
    {

    }

    public static explicit operator ProjectSchema(Project model) => new()
    {
        ProjectId = model.ProjectId,
        Title = model.Title,
        Description = model.Description
    };

    public static explicit operator Project(ProjectSchema schema) => new()
    {
        ProjectId = schema.ProjectId,
        Title = schema.Title,
        Description = schema.Description
    };
}
