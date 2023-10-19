using NetCoreCv.Core.Models;
using NetCoreCv.Api.Interfaces;

namespace NetCoreCv.Api.Schemas;
public class AddressSchema : ISchema<AddressSchema, Address>
{
    public int Id { get; set; }

    public string FirstLine { get; set; } = "";

    public string SecondLine { get; set; } = "";

    public string County { get; set; } = "";

    public Countries Country { get; set; }

    public string PostCode { get; set; } = "";

    public bool IsCurrent { get; set; }


    public static explicit operator AddressSchema(Address model) => new() {
        Id = model.AddressId,
        FirstLine = model.FirstLine,
        SecondLine = model.SecondLine,
        County = model.County,
        Country = model.Country,
        PostCode = model.PostCode,
        IsCurrent = model.IsCurrent
    };

    public static explicit operator Address(AddressSchema schema) => new() {
        AddressId = schema.Id,
        FirstLine = schema.FirstLine,
        SecondLine = schema.SecondLine,
        County = schema.County,
        Country = schema.Country,
        PostCode = schema.PostCode,
        IsCurrent = schema.IsCurrent
    };
}
