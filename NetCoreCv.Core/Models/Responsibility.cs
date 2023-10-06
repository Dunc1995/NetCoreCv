using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Models;
public class Responsibility
{
    public int ResponsibilityId { get; set; }

    public string Description { get; set; } = "";

    public int WorkExperienceId { get; set; }

    public WorkExperience? WorkExperience { get; set; }
}
