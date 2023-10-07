using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.Api.Schemas;

namespace NetCoreCv.Api.Controllers;
public class EducationController : CrudController<EducationSchema, Education>
{
    public EducationController(CvRepository context) : base(context)
    {

    }
}
