using Microsoft.AspNetCore.Identity;
using NetCoreCv.Api.Interfaces;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Api.Schemas;

public class CurriculumVitaeSchema : ISchema<CurriculumVitaeSchema, CurriculumVitae>
{
    public int Id => CurriculumVitaeId;

    public int CurriculumVitaeId { get; set; }

    public string UserName { get; set; } = "";

    public string EmailAddress { get; set; } = "";

    public int? CurrentAddressId { get; set; }

    public AddressSchema? CurrentAddress { get; set; }

    public IEnumerable<EducationSchema> Education { get; set; } = Enumerable.Empty<EducationSchema>();

    public IEnumerable<WorkExperienceSchema> WorkExperience { get; set; } = Enumerable.Empty<WorkExperienceSchema>();

    public IEnumerable<ProjectSchema> Projects { get; set; } = Enumerable.Empty<ProjectSchema>();

    public static explicit operator CurriculumVitaeSchema(CurriculumVitae model) => new() {
        CurriculumVitaeId = model.CurriculumVitaeId,
        UserName = model.User?.UserName ?? "",
        EmailAddress = model.User?.Email ?? "",
        Education = model.Education.Select(x => (EducationSchema)x),
        Projects = model.Projects.Select(x => (ProjectSchema)x),
        WorkExperience = model.WorkExperience
            .Select(x => (WorkExperienceSchema)x)
            .OrderBy(x => x.StartDate)
            .Reverse()
    };

    public static explicit operator CurriculumVitae(CurriculumVitaeSchema schema) => new() {
        // TODO pass user data back to model.
        CurriculumVitaeId = schema.CurriculumVitaeId,
        Education = schema.Education.Select(x => (Education)x),
        Projects = schema.Projects.Select(x => (Project)x),
        WorkExperience = schema.WorkExperience.Select(x => (WorkExperience)x)
    };
}