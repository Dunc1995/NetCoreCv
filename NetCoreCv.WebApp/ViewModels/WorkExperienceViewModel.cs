using NetCoreCv.Core.Models;

namespace NetCoreCv.WebApp.ViewModels;
public class WorkExperienceViewModel
{
    public int WorkExperienceId { get; set; }

    public string JobTitle { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public WorkExperienceViewModel()
    {

    }

    public static explicit operator WorkExperienceViewModel(WorkExperience workExperience)
    {
        return new WorkExperienceViewModel
        {
            WorkExperienceId = workExperience.WorkExperienceId,
            JobTitle = workExperience.JobTitle,
            StartDate = workExperience.StartDate,
            EndDate = workExperience.EndDate
        };
    }
}
