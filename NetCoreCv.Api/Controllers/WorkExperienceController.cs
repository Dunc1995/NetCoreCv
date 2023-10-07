using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.Api.Schemas;

namespace NetCoreCv.Api.Controllers;
public class WorkExperienceController : CrudController<WorkExperienceSchema, WorkExperience>
{
    public WorkExperienceController(CvRepository context) : base(context)
    {

    }
}
