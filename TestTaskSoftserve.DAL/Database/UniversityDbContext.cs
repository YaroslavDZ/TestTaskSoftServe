using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Configuration;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.DAL.Database;
using TestTaskSoftServe.DAL.Entities.User;

namespace TestTaskSoftserve.DAL.Database
{
    public class UniversityDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new StudentEntityConfiguration());
            builder.ApplyConfiguration(new CourseEntityConfiguration());
            builder.ApplyConfiguration(new TeacherEntityConfiguration());

            builder.SeedData();
        }
    }
}
