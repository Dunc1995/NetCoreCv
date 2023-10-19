namespace NetCoreCv.Core.Models;

public class Education
{
    public int EducationId { get; set; }

    public int? AddressId { get; set; }

    public int? CompanyId { get; set; }

    public string Title { get; set; } = "";

    public string Grade { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public Address? Address { get; set; }

    public Company? Company { get; set; }

    public int CurriculumVitaeId { get; set; }

    public CurriculumVitae? CurriculumVitae { get; set; }
}