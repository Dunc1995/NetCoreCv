using System.Collections;
using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp;

namespace NetCoreCv.WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class CrudController<U> : ControllerBase where U : class, new()
{
    private protected readonly CvRepository _context;

    public CrudController(CvRepository context)
    {
        _context = context;
    }

    [HttpGet("")]
    public virtual async Task<IEnumerable<U>> Index()
    {
        return (await _context.GetAllAsync<U>()).Select(x => x);
    }

    [HttpGet("Get")]
    [HttpGet("Get/{id:int}")]
    public virtual async Task<U> Get(int? id)
    {
        var model = new U();

        if (id != null) {
            var result = await _context.GetAsync<U>((int)id);

            if (result != null) {
                model = result;
            }
        }

        return model;
    }

    [HttpPut("Edit")]
    public async Task<IActionResult> Edit([FromBody]U model)
    {
        var _model = model; 

        await _context.PutAsync(model);

        return Ok();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id) {
        
        await _context.DeleteAsync<U>(id);

        return Ok();
    }
}
