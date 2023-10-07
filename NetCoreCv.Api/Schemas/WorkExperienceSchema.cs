using NetCoreCv.Core.Models;
using NetCoreCv.Api.Interfaces;

namespace NetCoreCv.Api.Schemas;
public class WorkExperienceSchema : ISchema<WorkExperienceSchema, WorkExperience>
{
    public int Id { get; set; }

    public int? AddressId { get; set; }

    public string JobTitle { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public AddressSchema? Address { get; set; }

    public IEnumerable<ResponsibilitySchema>? Responsibilities { get; set; }


    public static explicit operator WorkExperienceSchema(WorkExperience model) => new()
    {
        Id = model.WorkExperienceId,
        AddressId = model.AddressId,
        JobTitle = model.JobTitle,
        StartDate = model.StartDate,
        EndDate = model.EndDate,
        Address = model.Address != null ? (AddressSchema)model.Address : null,
        Responsibilities = model.Responsibilities?.Select(x => (ResponsibilitySchema)x) ?? Enumerable.Empty<ResponsibilitySchema>()
    };

    public static explicit operator WorkExperience(WorkExperienceSchema schema) => new()
    {
        WorkExperienceId = schema.Id,
        AddressId = schema.AddressId,
        JobTitle = schema.JobTitle,
        StartDate = schema.StartDate,
        EndDate = schema.EndDate,
        Address = schema.Address != null ? (Address)schema.Address : null,
        Responsibilities = schema.Responsibilities?.Select(x => (Responsibility)x) ?? Enumerable.Empty<Responsibility>()
    };
}
