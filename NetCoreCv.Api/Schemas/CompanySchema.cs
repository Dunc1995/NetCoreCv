using NetCoreCv.Core.Models;
using NetCoreCv.Api.Interfaces;
using NetCoreCv.Core.Helpers;

namespace NetCoreCv.Api.Schemas;
public class CompanySchema : ISchema<CompanySchema, Company>
{
    public int Id { get; set; }

    public string Name { get; set; } = "";


    public static explicit operator CompanySchema(Company model) => new() {
        Id = model.CompanyId,
        Name = model.Name,
    };

    public static explicit operator Company(CompanySchema schema) => new() {
        CompanyId = schema.Id,
        Name = schema.Name
    };
}
