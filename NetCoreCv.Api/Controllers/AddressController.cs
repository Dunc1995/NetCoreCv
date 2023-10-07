using Microsoft.AspNetCore.Mvc;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;
using NetCoreCv.Api.Schemas;

namespace NetCoreCv.Api.Controllers;
public class AddressController : CrudController<AddressSchema, Address>
{
    public AddressController(CvRepository context) : base(context)
    {

    }
}
