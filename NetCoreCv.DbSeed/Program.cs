using System;
using System.Linq;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;

using var db = new CvContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
db.Add(new WorkExperience
{
    WorkExperienceId = 1,
    JobTitle = "CAD Technician",
    StartDate = DateTime.Today,
    EndDate = DateTime.Today,
    CompanyId = 1,
    Company = new() {
        CompanyId = 1,
        Name = "Hygiene Teknikk Ltd"     
    },
    AddressId = 1,
    Address = new() {
        AddressId = 1,
        FirstLine = "Glengallan Industrial Estate",
        SecondLine = "7E Glengallan Road",
        TownOrCity = "Oban",
        PostCode = "PA34 4HG",
        Country = Countries.UnitedKingdom
    }
});

db.Add(new WorkExperience
{
    WorkExperienceId = 2,
    JobTitle = "Summer Student",
    StartDate = DateTime.Today,
    EndDate = DateTime.Today,
    CompanyId = 2,
    Company = new() {
        CompanyId = 2,
        Name = "Total Waste Management Alliance (TWMA)"     
    },
    AddressId = 2,
    Address = new() {
        AddressId = 2,
        FirstLine = "Glengallan Industrial Estate",
        SecondLine = "7E Glengallan Road",
        PostCode = "PA34 4HG",
        Country = Countries.UnitedKingdom
    }
});

db.Add(new WorkExperience
{
    WorkExperienceId = 3,
    JobTitle = "Graduate Engineering Technology Consultant",
    StartDate = DateTime.Today,
    EndDate = DateTime.Today,
    CompanyId = 3,
    Company = new() {
        CompanyId = 3,
        Name = "Hygiene Teknikk Ltd"     
    },
    AddressId = 3,
    Address = new() {
        AddressId = 3,
        FirstLine = "Glengallan Industrial Estate",
        SecondLine = "7E Glengallan Road",
        PostCode = "PA34 4HG",
        Country = Countries.UnitedKingdom
    }
});

db.Add(new WorkExperience
{
    WorkExperienceId = 4,
    JobTitle = "Associate Cloud Operations Engineer",
    StartDate = DateTime.Today,
    EndDate = DateTime.Today,
    CompanyId = 4,
    Company = new() {
        CompanyId = 4,
        Name = "Hygiene Teknikk Ltd"     
    },
    AddressId = 4,
    Address = new() {
        AddressId = 4,
        FirstLine = "Glengallan Industrial Estate",
        SecondLine = "7E Glengallan Road",
        PostCode = "PA34 4HG",
        Country = Countries.UnitedKingdom
    }
});

var skiptonAddress = new Address() {
        AddressId = 5,
        FirstLine = "No. 1 Broughton Park",
        SecondLine = "Old Lane North",
        TownOrCity = "Skipton",
        PostCode = "BD23 3FD",
        Country = Countries.UnitedKingdom
    };

var jbaConsulting = new Company() {
        CompanyId = 5,
        Name = "JBA Consulting"     
    };

db.Add(new WorkExperience
{
    WorkExperienceId = 5,
    JobTitle = "Software Developer (Analyst Grade 2)",
    StartDate = DateTime.Today,
    EndDate = DateTime.Today,
    CompanyId = 5,
    Company = jbaConsulting,
    AddressId = 5,
    Address = skiptonAddress
});

db.Add(new WorkExperience
{
    WorkExperienceId = 6,
    JobTitle = "Software Developer (Analyst Grade 1)",
    StartDate = DateTime.Today,
    EndDate = DateTime.Today,
    CompanyId = 5,
    Company = jbaConsulting,
    AddressId = 5,
    Address = skiptonAddress
});
db.SaveChanges();