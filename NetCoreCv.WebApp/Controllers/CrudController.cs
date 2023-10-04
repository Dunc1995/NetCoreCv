﻿using System.Collections;
using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Interfaces;
using NetCoreCv.WebApp;

namespace NetCoreCv;

public abstract class CrudController<T, U> : Controller
    where T : class, new()
    where U : IRepository<T>
{
    private protected readonly IRepository<T> _context;

    public CrudController(IRepository<T> context)
    {
        _context = context;
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id) {
        
        await _context.DeleteAsync(id);

        return Ok();
    }
}
