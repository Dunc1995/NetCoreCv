using NetCoreCv.Api.Interfaces;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Api.Schemas;

public class DateRangeSchema : ISchema<DateRangeSchema, DateRange>
{
    public int Id { get; set; }

    public int WorkExperienceId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public static explicit operator DateRangeSchema(DateRange model) => new()
    {
        Id = model.DateRangeId,
        WorkExperienceId = model.WorkExperienceId,
        StartDate = model.StartDate,
        EndDate = model.EndDate
    };

    public static explicit operator DateRange(DateRangeSchema schema) => new()
    {
        DateRangeId = schema.Id,
        WorkExperienceId = schema.WorkExperienceId,
        StartDate = schema.StartDate,
        EndDate = schema.EndDate
    };
}