using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.Api.Schemas;

namespace NetCoreCv.Api.Controllers;

public class ResponsibilitiesController : CrudController<ResponsibilitySchema, Responsibility>
{
    public ResponsibilitiesController(CvRepository context) : base(context)
    {

    }
}
