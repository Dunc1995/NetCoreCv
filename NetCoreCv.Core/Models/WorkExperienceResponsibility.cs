using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Models;
public class WorkExperienceResponsibility : IModel
{
    public int Id => WorkExperienceResponsibilityId;

    public int WorkExperienceResponsibilityId { get; set; }

    public string Description { get; set; } = "";

    public int WorkExperienceId { get; set; }

    public WorkExperience? WorkExperience { get; set; }
}
