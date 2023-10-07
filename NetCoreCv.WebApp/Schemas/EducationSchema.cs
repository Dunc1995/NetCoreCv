using NetCoreCv.Core.Models;
using NetCoreCv.WebApp.Interfaces;

namespace NetCoreCv.WebApp;
public class EducationSchema : ISchema<EducationSchema, Education>
{
    public int Id { get; set; }

    public int? AddressId { get; set; }

    public string Title { get; set; } = "";

    public string Grade { get; set; } = "";

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public AddressSchema? Address { get; set; }
    
    public static explicit operator EducationSchema(Education model) => new() {
        Id = model.EducationId,
        AddressId = model.AddressId,
        Title = model.Title,
        Grade = model.Grade,
        StartDate = model.StartDate,
        EndDate = model.EndDate,
        Address = model.Address != null ? (AddressSchema)model.Address : null
    };

    public static explicit operator Education(EducationSchema schema) => new() {
        EducationId = schema.Id,
        AddressId = schema.AddressId,
        Title = schema.Title,
        Grade = schema.Grade,
        StartDate = schema.StartDate,
        EndDate = schema.EndDate,
        Address = schema.Address != null ? (Address)schema.Address : null
    };
}
