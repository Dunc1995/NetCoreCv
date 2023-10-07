﻿using Microsoft.EntityFrameworkCore;
using NetCoreCv.Core.Models;
using System;
using System.Collections.Generic;

namespace NetCoreCv.Core.Repositories
{
    public class CvContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public DbSet<WorkExperience> WorkExperiences { get; set; }

        public DbSet<Responsibility> WorkExperienceResponsibilities { get; set; }

        public string DbPath { get; }

        public CvContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "cv.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkExperience>().Navigation(x => x.Responsibilities).AutoInclude();
        }
    }
}
