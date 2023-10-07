using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.Schemas;

namespace NetCoreCv.WebApp.Controllers;
public class EducationController : CrudController<EducationSchema, Education>
{
    public EducationController(CvRepository context) : base(context)
    {

    }
}
