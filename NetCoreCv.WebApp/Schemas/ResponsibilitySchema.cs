using NetCoreCv.Core.Models;
using NetCoreCv.WebApp.Interfaces;

namespace NetCoreCv.WebApp.Schemas;
public class ResponsibilitySchema : ISchema<ResponsibilitySchema, Responsibility>
{
    public int Id => ResponsibilityId;

    public int ResponsibilityId { get; set; }

    public string Description { get; set; } = "";

    public int WorkExperienceId { get; set; }


    public static explicit operator ResponsibilitySchema(Responsibility model) => new()
    {
        ResponsibilityId = model.ResponsibilityId,
        Description = model.Description,
        WorkExperienceId = model.WorkExperienceId
    };

    public static explicit operator Responsibility(ResponsibilitySchema schema) => new()
    {
        ResponsibilityId = schema.ResponsibilityId,
        Description = schema.Description,
        WorkExperienceId = schema.WorkExperienceId
    };
}
