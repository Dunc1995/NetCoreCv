namespace NetCoreCv.Core.Models;

public class Address
{
    public int AddressId { get; set; }

    public string FirstLine { get; set; } = "";

    public string SecondLine { get; set; } = "";

    public string TownOrCity { get; set; } = "";

    public string County { get; set; } = "";

    public Countries Country { get; set; }

    public string PostCode { get; set; } = "";

    public bool IsCurrent { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public IEnumerable<Project>? Projects { get; set; }

    public IEnumerable<WorkExperience>? WorkExperiences { get; set; }

    public IEnumerable<Education>? Education { get; set; }

    public Address()
    {

    }
}
