namespace NetCoreCv.Core.Models;
public class WorkExperience
{
    public int WorkExperienceId { get; set; }

    public int? AddressId { get; set; }

    public int? CompanyId { get; set; }

    public string JobTitle { get; set; } = "";

    public IEnumerable<DateRange>? WorkPeriods { get; set; }

    public Address? Address { get; set; }

    public Company? Company { get; set; }

    public IEnumerable<Responsibility>? Responsibilities { get; set; }

    public int CurriculumVitaeId { get; set; }

    public CurriculumVitae? CurriculumVitae { get; set; }

    public WorkExperience() {

    }
}
