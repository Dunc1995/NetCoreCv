namespace NetCoreCv.Core.Models;

public class DateRange {
    public int DateRangeId { get; set; }

    public int WorkExperienceId { get; set; }

    public WorkExperience? WorkExperience { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}