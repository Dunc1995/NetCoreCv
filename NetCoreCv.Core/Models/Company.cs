namespace NetCoreCv.Core.Models;

public class Company {
    public int CompanyId { get; set; }

    public string Name { get; set; } = "";

    public ICollection<Education>? Education { get; set; }

    public ICollection<WorkExperience>? WorkExperience { get; set; }
}