using System.Collections;
using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Interfaces;
using NetCoreCv.WebApp;
using NetCoreCv.WebApp.Interfaces;

namespace NetCoreCv.WebApp.Controllers;

public abstract class CrudController<T, U, V> : Controller
    where T : IViewModel<T, U>, new()
    where U : class, new()
    where V : IRepository<U>
{
    private protected readonly IRepository<U> _context;

    public CrudController(IRepository<U> context)
    {
        _context = context;
    }

    public virtual async Task<IActionResult> Index()
    {
        return View((await _context.GetAllAsync()).Select(x => (T)x));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        var model = new T();

        if (id != null) {
            var result = await _context.GetAsync((int)id);

            if (result != null) {
                model = (T)result;
            }
        }

        return View(model);
    }

    [HttpPut]
    public async Task<IActionResult> Edit([FromBody]T model)
    {
        var _model = (U)model; 

        await _context.PutAsync(_model);

        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id) {
        
        await _context.DeleteAsync(id);

        return Ok();
    }
}
