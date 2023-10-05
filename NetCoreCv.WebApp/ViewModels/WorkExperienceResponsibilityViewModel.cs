using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.WebApp.Interfaces;

namespace NetCoreCv.WebApp.ViewModels;
public class WorkExperienceResponsibilityViewModel : IViewModel<WorkExperienceResponsibilityViewModel, WorkExperienceResponsibility>
{
    [HiddenInput]
    public int WorkExperienceResponsibilityId { get; set; }

    [HiddenInput]
    public int WorkExperienceId { get; set; }

    [MinLength(10)]
    [MaxLength(250)]
    public string Description { get; set; } = "";


    public static explicit operator WorkExperienceResponsibilityViewModel(WorkExperienceResponsibility workExperience) => new()
    {
        WorkExperienceResponsibilityId = workExperience.WorkExperienceResponsibilityId,
        WorkExperienceId = workExperience.WorkExperienceId,
        Description = workExperience.Description
    };

    public static explicit operator WorkExperienceResponsibility(WorkExperienceResponsibilityViewModel workExperience) => new()
    {
        WorkExperienceResponsibilityId = workExperience.WorkExperienceResponsibilityId,
        WorkExperienceId = workExperience.WorkExperienceId,
        Description = workExperience.Description
    };
}
