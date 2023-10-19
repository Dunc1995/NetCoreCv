using System;
using System.Globalization;
using System.Linq;
using NetCoreCv.Core.Helpers;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;

using var db = new CvContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

var userId = Guid.NewGuid().ToString();

db.Add(new CurriculumVitae() {
    CurriculumVitaeId = 1,
    User = new() {
        Id = userId,
        UserName = "Duncan Bailey",
        NormalizedUserName = "DuncanBailey",
        Email = "duncanbailey1995@gmail.com",
        NormalizedEmail = "DUNCANBAILEY1995@GMAIL.COM"
    }
});

// Create
db.Add(new WorkExperience
{
    CurriculumVitaeId = 1,
    WorkExperienceId = 1,
    JobTitle = "CAD Technician",
    WorkPeriods = DateUtils.GetDateRanges(new string[] { "07/2014", "09/2014", "07/2016", "09/2016" }),
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
    CurriculumVitaeId = 1,
    WorkExperienceId = 2,
    JobTitle = "Summer Student",
    WorkPeriods = DateUtils.GetDateRanges(new string[] { "07/2017", "09/2017" }),
    CompanyId = 2,
    Company = new() {
        CompanyId = 2,
        Name = "Total Waste Management Alliance (TWMA)"     
    },
    AddressId = 2,
    Address = new() {
        AddressId = 2,
        FirstLine = "Building 3, Aberdeen International Business Park",
        SecondLine = "Dyce Drive",
        PostCode = "AB21 0BR",
        TownOrCity = "Aberdeen",
        Country = Countries.UnitedKingdom
    }
});

db.Add(new WorkExperience
{
    CurriculumVitaeId = 1,
    WorkExperienceId = 3,
    JobTitle = "Graduate Engineering Technology Consultant",
    WorkPeriods = DateUtils.GetDateRanges(new string[] { "08/2018", "06/2019" }),
    CompanyId = 3,
    Company = new() {
        CompanyId = 3,
        Name = "Mott MacDonald"     
    },
    AddressId = 3,
    Address = new() {
        AddressId = 3,
        FirstLine = "319 St Vincent Street",
        PostCode = "G2 5LD",
        TownOrCity = "Glasgow",
        Country = Countries.UnitedKingdom
    }
});

db.Add(new WorkExperience
{
    CurriculumVitaeId = 1,
    WorkExperienceId = 4,
    JobTitle = "Associate Cloud Operations Engineer",
    WorkPeriods = DateUtils.GetDateRanges(new string[] { "07/2019", "03/2020" }),
    CompanyId = 4,
    Company = new() {
        CompanyId = 4,
        Name = "Cloudreach"     
    },
    AddressId = 4,
    Address = new() {
        AddressId = 4,
        FirstLine = "WeWork",
        SecondLine = "80 George Street",
        PostCode = "EH2 3BU",
        TownOrCity = "Edinburgh",
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
    CurriculumVitaeId = 1,
    WorkExperienceId = 5,
    JobTitle = "Software Developer (Analyst Grade 2)",
    WorkPeriods = DateUtils.GetDateRanges(new string[] { "10/2020", "11/2022" }),
    CompanyId = 5,
    Company = jbaConsulting,
    AddressId = 5,
    Address = skiptonAddress
});

db.Add(new WorkExperience
{
    CurriculumVitaeId = 1,
    WorkExperienceId = 6,
    JobTitle = "Software Developer (Analyst Grade 1)",
    WorkPeriods = DateUtils.GetDateRanges(new string[] { "11/2022", "02/2023" }),
    CompanyId = 5,
    Company = jbaConsulting,
    AddressId = 5,
    Address = skiptonAddress
});
db.SaveChanges();

Console.WriteLine("Data uploaded successfully.");