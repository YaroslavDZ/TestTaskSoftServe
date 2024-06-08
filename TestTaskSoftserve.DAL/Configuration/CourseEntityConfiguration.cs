using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;

namespace TestTaskSoftserve.DAL.Configuration
{
    internal class CourseEntityConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder
                .Property(c => c.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(c => c.Description)
                .HasMaxLength(500);
        }
    }
}
