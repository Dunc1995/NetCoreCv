using NetCoreCv.Core.Models;
using NetCoreCv.WebApp.Interfaces;
using NetCoreCv.WebApp.Schemas;

namespace NetCoreCv.WebApp;
public class AddressSchema : ISchema<AddressSchema, Address>
{
    public int Id { get; set; }

    public string FirstLine { get; set; } = "";

    public string SecondLine { get; set; } = "";

    public string County { get; set; } = "";

    public string PostCode { get; set; } = "";

    public bool IsCurrent { get; set; }

    public IEnumerable<ProjectSchema>? Projects { get; set; }

    public IEnumerable<WorkExperienceSchema>? WorkExperiences { get; set; }

    public IEnumerable<EducationSchema>? Education { get; set; }


    public static explicit operator AddressSchema(Address model) => new() {
        Id = model.AddressId,
        FirstLine = model.FirstLine,
        SecondLine = model.SecondLine,
        County = model.County,
        PostCode = model.PostCode,
        IsCurrent = model.IsCurrent,
        Projects = model.Projects?.Select(x => (ProjectSchema)x) ?? Enumerable.Empty<ProjectSchema>(),
        WorkExperiences = model.WorkExperiences?.Select(x => (WorkExperienceSchema)x) ?? Enumerable.Empty<WorkExperienceSchema>(),
        Education = model.Education?.Select(x => (EducationSchema)x) ?? Enumerable.Empty<EducationSchema>()
    };

    public static explicit operator Address(AddressSchema schema) => new() {
        AddressId = schema.Id,
        FirstLine = schema.FirstLine,
        SecondLine = schema.SecondLine,
        County = schema.County,
        PostCode = schema.PostCode,
        IsCurrent = schema.IsCurrent,
        Projects = schema.Projects?.Select(x => (Project)x) ?? Enumerable.Empty<Project>(),
        WorkExperiences = schema.WorkExperiences?.Select(x => (WorkExperience)x) ?? Enumerable.Empty<WorkExperience>(),
        Education = schema.Education?.Select(x => (Education)x) ?? Enumerable.Empty<Education>()
    };
}
