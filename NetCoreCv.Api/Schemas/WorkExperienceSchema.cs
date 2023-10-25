using NetCoreCv.Core.Models;
using NetCoreCv.Api.Interfaces;
using System.ComponentModel.DataAnnotations;
using NetCoreCv.Core.Helpers;

namespace NetCoreCv.Api.Schemas;
public class WorkExperienceSchema : ISchema<WorkExperienceSchema, WorkExperience>
{
    public int Id { get; set; }

    public int? AddressId { get; set; }

    public int? CompanyId { get; set; }

    public string JobTitle { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string StartDateDisplay => StartDate.ToString("MMMM yyyy");

    public string EndDateDisplay => EndDate.ToString("MMMM yyyy");

    public AddressSchema? Address { get; set; }

    public CompanySchema? Company { get; set; }

    public IEnumerable<ResponsibilitySchema>? Responsibilities { get; set; }


    public static explicit operator WorkExperienceSchema(WorkExperience model)
    {
        var dateRange = model.WorkPeriods.ElementAt(0); //TODO: Extend functionality to show multiple date ranges.

        return new()
        {
            Id = model.WorkExperienceId,
            AddressId = model.AddressId,
            CompanyId = model.CompanyId,
            JobTitle = model.JobTitle,
            StartDate = dateRange.StartDate,
            EndDate = dateRange.EndDate,
            Address = model.Address != null ? (AddressSchema)model.Address : null,
            Company = model.Company != null ? (CompanySchema)model.Company : null,
            Responsibilities = model.Responsibilities?.Select(x => (ResponsibilitySchema)x) ?? Enumerable.Empty<ResponsibilitySchema>()
        };
    }

    public static explicit operator WorkExperience(WorkExperienceSchema schema) => new()
    {
        WorkExperienceId = schema.Id,
        AddressId = schema.AddressId,
        CompanyId = schema.CompanyId,
        JobTitle = schema.JobTitle,
        WorkPeriods = DateUtils.GetDateRanges(new string[] { schema.StartDate.ToString("mm/yyyy"), schema.EndDate.ToString("mm/yyyy") }),
        Address = schema.Address != null ? (Address)schema.Address : null,
        Company = schema.Company != null ? (Company)schema.Company : null,
        Responsibilities = schema.Responsibilities?.Select(x => (Responsibility)x) ?? Enumerable.Empty<Responsibility>()
    };
}
