using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.Api.Schemas;

namespace NetCoreCv.Api.Controllers;
public class CurriculumVitaeController : CrudController<CurriculumVitaeSchema, CurriculumVitae>
{
    public CurriculumVitaeController(CvRepository context) : base(context)
    {

    }
}
