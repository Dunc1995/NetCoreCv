using System;
using System.Linq;
using NetCoreCv.Core.Models;
using NetCoreCv.Core.Repositories;

using var db = new CvContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new work experience");
db.Add(new WorkExperience
{
    WorkExperienceId = 1,
    JobTitle = "Unemployed",
    StartDate = DateTime.Today,
    EndDate = DateTime.Today
});
db.SaveChanges();