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
    internal class TeacherEntityConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .Property(t => t.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(t => t.Surname)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(t => t.Age)
                .IsRequired();

            builder
                .Property(t => t.Experience)
                .IsRequired();
        }
    }
}
