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
    internal class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .Property(s => s.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(s => s.Surname)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(s => s.Age)
                .IsRequired();

            builder
                .Property(s => s.StudyYear)
                .IsRequired();

            builder
                .Property(s => s.Group)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
