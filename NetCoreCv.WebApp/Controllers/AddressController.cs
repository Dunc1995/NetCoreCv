using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.WebApp.Schemas;

namespace NetCoreCv.WebApp.Controllers;
public class AddressController : CrudController<AddressSchema, Address>
{
    public AddressController(CvRepository context) : base(context)
    {

    }
}
