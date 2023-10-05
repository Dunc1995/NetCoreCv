using NetCoreCv.WebApp.ViewModels;

namespace NetCoreCv.WebApp.ViewModels;
public class WorkExperienceResponsibilitiesViewModel
{
    public string JobTitle { get; set; } = "";

    public IEnumerable<WorkExperienceResponsibilityViewModel> Responsibilities { get; set; } = Enumerable.Empty<WorkExperienceResponsibilityViewModel>();
}
