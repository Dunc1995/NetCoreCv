using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;

namespace NetCoreCv.WebApp.ViewModels;
public class WorkExperienceViewModel
{
    [HiddenInput]
    public int WorkExperienceId { get; set; }

    [Required]
    [Display(Name = "Job Title")]
    public string JobTitle { get; set; } = "";

    [Display(Name = "Start Date")]
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }

    [Display(Name = "End Date")]
    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }

    public WorkExperienceViewModel()
    {

    }

    public static explicit operator WorkExperienceViewModel(WorkExperience workExperience) => new()
    {
        WorkExperienceId = workExperience.WorkExperienceId,
        JobTitle = workExperience.JobTitle,
        StartDate = workExperience.StartDate,
        EndDate = workExperience.EndDate
    };

    public static explicit operator WorkExperience(WorkExperienceViewModel workExperience) => new()
    {
        WorkExperienceId = workExperience.WorkExperienceId,
        JobTitle = workExperience.JobTitle,
        StartDate = workExperience.StartDate,
        EndDate = workExperience.EndDate
    };
}
