using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using NetCoreCv.Core.Models;
using System;
using System.Collections.Generic;

namespace NetCoreCv.Core.Repositories
{
    public class CvContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<WorkExperience> WorkExperiences { get; set; }

        public DbSet<Responsibility> Responsibilities { get; set; }

        public DbSet<Education> Education { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<DateRange> DateRanges { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public string DbPath { get; }

        public CvContext()
        {
            var folder = Environment.SpecialFolder.Personal;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "cv.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //I'm being lazy here.
            modelBuilder.Entity<WorkExperience>().Navigation(x => x.Responsibilities).AutoInclude();
            modelBuilder.Entity<WorkExperience>().Navigation(x => x.WorkPeriods).AutoInclude();
            modelBuilder.Entity<CurriculumVitae>().Navigation(x => x.User).AutoInclude();
            modelBuilder.Entity<CurriculumVitae>().Navigation(x => x.Projects).AutoInclude();
            modelBuilder.Entity<CurriculumVitae>().Navigation(x => x.Education).AutoInclude();
        }
    }
}
