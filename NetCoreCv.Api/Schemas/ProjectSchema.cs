using NetCoreCv.Core.Models;
using NetCoreCv.Api.Interfaces;

namespace NetCoreCv.Api.Schemas;
public class ProjectSchema : ISchema<ProjectSchema, Project>
{
    public int Id { get; set; }

    public int? AddressId { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public AddressSchema? Address { get; set; }

    public ProjectSchema()
    {

    }

    public static explicit operator ProjectSchema(Project model) => new()
    {
        Id = model.ProjectId,
        Title = model.Title,
        Description = model.Description,
        AddressId = model.AddressId,
        Address = model.Address != null ? (AddressSchema)model.Address : null
    };

    public static explicit operator Project(ProjectSchema schema) => new()
    {
        ProjectId = schema.Id,
        Title = schema.Title,
        Description = schema.Description,
        AddressId = schema.AddressId,
        Address = schema.Address != null ? (Address)schema.Address : null
    };
}
