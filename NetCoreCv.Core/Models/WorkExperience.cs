namespace NetCoreCv.Core.Models;
public class WorkExperience : IModel
{
    public int Id => WorkExperienceId;

    public int WorkExperienceId { get; set; }

    public string JobTitle { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public IEnumerable<WorkExperienceResponsibility>? Responsibilities { get; set; }

    public WorkExperience() {

    }
}
