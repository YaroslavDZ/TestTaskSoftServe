using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Configuration;
using TestTaskSoftserve.DAL.Entities;

namespace TestTaskSoftserve.DAL.Database
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StudentEntityConfiguration());
            builder.ApplyConfiguration(new CourseEntityConfiguration());
            builder.ApplyConfiguration(new TeacherEntityConfiguration());
        }
    }
}
