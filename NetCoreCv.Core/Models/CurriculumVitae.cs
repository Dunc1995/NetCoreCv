using Microsoft.AspNetCore.Identity;

namespace NetCoreCv.Core.Models;

public class CurriculumVitae
{
    public int CurriculumVitaeId { get; set; }

    public string? UserId { get; set; }

    public IdentityUser? User { get; set; }

    public int? CurrentAddressId { get; set; }

    public Address? CurrentAddress { get; set; }

    public IEnumerable<Education>? Education { get; set; }

    public IEnumerable<WorkExperience>? WorkExperience { get; set; }

    public IEnumerable<Project>? Projects { get; set; }
}