using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;

namespace NetCoreCv.WebApp.Controllers;
public class WorkExperienceController : CrudController<WorkExperience>
{
    public WorkExperienceController(CvRepository context) : base(context)
    {

    }

    public override async Task<WorkExperience> Get(int? id)
    {
        var model = new WorkExperience();

        if (id != null) {
            var result = await _context.GetWorkExperienceAsync((int)id);

            if (result != null) {
                model = result;
            }
        }

        return model;
    }
}
