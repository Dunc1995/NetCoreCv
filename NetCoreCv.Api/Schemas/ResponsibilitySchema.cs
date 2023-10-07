using NetCoreCv.Core.Models;
using NetCoreCv.Api.Interfaces;

namespace NetCoreCv.Api.Schemas;
public class ResponsibilitySchema : ISchema<ResponsibilitySchema, Responsibility>
{
    public int Id { get; set; }

    public string Description { get; set; } = "";

    public int WorkExperienceId { get; set; }


    public static explicit operator ResponsibilitySchema(Responsibility model) => new()
    {
        Id = model.ResponsibilityId,
        Description = model.Description,
        WorkExperienceId = model.WorkExperienceId
    };

    public static explicit operator Responsibility(ResponsibilitySchema schema) => new()
    {
        ResponsibilityId = schema.Id,
        Description = schema.Description,
        WorkExperienceId = schema.WorkExperienceId
    };
}
