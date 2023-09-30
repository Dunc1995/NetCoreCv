using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Interfaces;

namespace NetCoreCv;

public abstract class CrudController<T, U, V> : Controller
    where T : V, new()
    where U : IRepository<V>
    where V : class, new()
{
    private readonly IRepository<V> _context;

    public CrudController(IRepository<V> context) {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var items = await _context.GetAllAsync();

        return View(items.Select(x => (T)x));
    }

    // [HttpPut]
    // public T Edit() {
    //     return new T();
    // }
}
