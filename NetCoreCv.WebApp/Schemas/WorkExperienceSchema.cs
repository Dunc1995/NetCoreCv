using NetCoreCv.Core.Models;
using NetCoreCv.WebApp.Interfaces;

namespace NetCoreCv.WebApp.Schemas;
public class WorkExperienceSchema : ISchema<WorkExperienceSchema, WorkExperience>
{
    public int Id => WorkExperienceId;

    public int WorkExperienceId { get; set; }

    public string JobTitle { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public IEnumerable<ResponsibilitySchema>? Responsibilities { get; set; }


    public static explicit operator WorkExperienceSchema(WorkExperience model) => new()
    {
        WorkExperienceId = model.WorkExperienceId,
        JobTitle = model.JobTitle,
        StartDate = model.StartDate,
        EndDate = model.EndDate,
        Responsibilities = model.Responsibilities?.Select(x => (ResponsibilitySchema)x) ?? Enumerable.Empty<ResponsibilitySchema>()
    };

    public static explicit operator WorkExperience(WorkExperienceSchema schema) => new()
    {
        WorkExperienceId = schema.WorkExperienceId,
        JobTitle = schema.JobTitle,
        StartDate = schema.StartDate,
        EndDate = schema.EndDate,
        Responsibilities = schema.Responsibilities?.Select(x => (Responsibility)x) ?? Enumerable.Empty<Responsibility>()
    };
}
