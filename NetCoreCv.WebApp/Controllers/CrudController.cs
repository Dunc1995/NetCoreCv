using System.Collections;
using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp;
using NetCoreCv.WebApp.Interfaces;

namespace NetCoreCv.WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class CrudController<T, U> : ControllerBase 
where T : class, ISchema<T, U>
where U : class, new()
{
    private protected readonly CvRepository _context;

    public CrudController(CvRepository context)
    {
        _context = context;
    }

    [HttpGet("")]
    public virtual async Task<IEnumerable<T>> Index()
    {
        return (await _context.GetAllAsync<U>()).Select(x => (T)x);
    }

    [HttpGet("Get")]
    [HttpGet("Get/{id:int}")]
    public virtual async Task<T> Get(int? id)
    {
        var model = new U();

        if (id != null) {
            var result = await _context.GetAsync<U>((int)id);

            if (result != null) {
                model = result;
            }
        }

        return (T)model;
    }

    [HttpPut("Put")]
    public async Task<IActionResult> Put([FromBody]T schema)
    {
        await _context.PutAsync(schema.Id, (U)schema);

        return Ok();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id) {
        
        await _context.DeleteAsync<U>(id);

        return Ok();
    }
}
