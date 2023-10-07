using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.Schemas;

namespace NetCoreCv.WebApp.Controllers;

public class ResponsibilitiesController : CrudController<ResponsibilitySchema, Responsibility>
{
    public ResponsibilitiesController(CvRepository context) : base(context)
    {

    }
}
