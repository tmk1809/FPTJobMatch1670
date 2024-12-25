using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FPTJobMatch1670.Models;
using System.Drawing.Drawing2D;
using Microsoft.Build.Framework;

namespace FPTJobMatch1670.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FPTJobMatch1670.Models.Job> Job { get; set; }
        public DbSet<FPTJobMatch1670.Models.Application> Application { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed data for User & Role
            SeedUserRole(builder);
            SeedJob(builder);

        }

        private void SeedUserRole(ModelBuilder builder)
        {
            //add data for "user"
            var admin = new IdentityUser
            {
                Id = "admin-account",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true
            };
            var employer = new IdentityUser
            {
                Id = "employer-account",
                UserName = "employer@gmail.com",
                Email = "employer@gmail.com",
                NormalizedUserName = "EMPLOYER@GMAIL.COM",
                NormalizedEmail = "EMPLOYER@GMAIL.COM",
                EmailConfirmed = true
            };
            var seeker = new IdentityUser
            {
                Id = "seeker-account",
                UserName = "seeker@gmail.com",
                Email = "seeker@gmail.com",
                NormalizedUserName = "SEEKER@GMAIL.COM",
                NormalizedEmail = "SEEKER@GMAIL.COM",
                EmailConfirmed = true
            };
            //set password for accounts
            var hasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            employer.PasswordHash = hasher.HashPassword(employer, "123456");
            seeker.PasswordHash = hasher.HashPassword(seeker, "123456");
            //add account to db
            builder.Entity<IdentityUser>().HasData(admin, employer, seeker);

            //add data for "role"
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "admin-role",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "employer-role",
                    Name = "Employer",
                    NormalizedName = "EMPLOYER"
                },
                new IdentityRole
                {
                    Id = "seeker-role",
                    Name = "Seeker",
                    NormalizedName = "SEEKER"
                });
            //assign role to user
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "admin-account",
                    RoleId = "admin-role"
                },
                new IdentityUserRole<string>
                {
                    UserId = "employer-account",
                    RoleId = "employer-role"
                },
                new IdentityUserRole<string>
                {
                    UserId = "seeker-account",
                    RoleId = "seeker-role"
                }
                );
        }
        private void SeedJob (ModelBuilder builder)
        {
            builder.Entity<Job>().HasData(
                new Job
                {
                    Id = 1,
                    Name = "Software Engineer",
                    Description = "Develop and maintain web applications.",
                    Location = "New York, NY",
                    Salary = 90000,
                },
                new Job
                {
                    Id = 2,
                    Name = "Marketing Manager",
                    Description = "Plan and execute marketing campaigns.",
                    Location = "Los Angeles, CA",
                    Salary = 75000,
                },
                new Job
                {
                    Id = 3,
                    Name = "Data Analyst",
                    Description = "Analyze and interpret complex data sets.",
                    Location = "San Francisco, CA",
                    Salary = 85000,
                },
                new Job
                {
                    Id = 4,
                    Name = "Human Resources Specialist",
                    Description = "Manage employee relations and recruitment efforts.",
                    Location = "Chicago, IL",
                    Salary = 60000,
                },
                new Job
                {
                    Id = 5,
                    Name = "Project Manager",
                    Description = "Oversee and coordinate project activities.",
                    Location = "Austin, TX",
                    Salary = 95000,
                });
        }
    }
}