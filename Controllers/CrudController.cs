using Microsoft.AspNetCore.Mvc;

namespace NetCoreCv;

public class CrudController<T> : Controller where T : class, new()
{
    [HttpPut]
    public T Edit() {
        return new T();
    }
}
