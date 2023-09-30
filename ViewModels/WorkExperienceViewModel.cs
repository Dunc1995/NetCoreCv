namespace NetCoreCv;
public class WorkExperienceViewModel
{
    public int WorkExperienceId { get; set; }

    public string JobTitle { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public WorkExperienceViewModel() {

    }
}
