namespace NetCoreCv.Core.Models;
public class WorkExperience
{
    public int WorkExperienceId { get; set; }

    public int? AddressId { get; set; }

    public int? CompanyId { get; set; }

    public string JobTitle { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public Address? Address { get; set; }

    public Company? Company { get; set; }

    public IEnumerable<Responsibility>? Responsibilities { get; set; }

    public WorkExperience() {

    }
}
