﻿using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.Schemas;

namespace NetCoreCv.WebApp.Controllers;
public class WorkExperienceController : CrudController<WorkExperienceSchema, WorkExperience>
{
    public WorkExperienceController(CvRepository context) : base(context)
    {

    }
}
