namespace NetCoreCv.Core.Models;
public class WorkExperience
{
    public int WorkExperienceId { get; set; }

    public string JobTitle { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public WorkExperience() {

    }
}
