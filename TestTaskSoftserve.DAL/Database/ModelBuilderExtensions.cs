using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;

namespace TestTaskSoftServe.DAL.Database
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            SeedCourses(modelBuilder);
            SeedStudents(modelBuilder);
            SeedTeachers(modelBuilder);
        }

        private static void SeedCourses(this ModelBuilder modelBuilder) 
        {
            const int QUANTITY = 20;
            List<Course> courses = new List<Course>(QUANTITY);

            for (int i = 0; i < QUANTITY; i++)
            {
                var course = new Course()
                {
                    Id = Guid.NewGuid(),
                    Title = $"Course {i + 1}",
                    Description = $"Description {i + 1}"
                };

                courses.Add(course);
            }

            modelBuilder.Entity<Course>().HasData(courses);
        }

        private static void SeedStudents(this ModelBuilder modelBuilder)
        {
            const int QUANTITY = 10;
            const int MINAGE = 18;
            const int MAXAGE = 110;
            List<Student> students = new List<Student>(QUANTITY);

            for (int i = 0; i < QUANTITY; i++)
            {
                var random = new Random();
                var course = new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = $"Student's name {i + 1}",
                    Surname = $"Student's surname {i + 1}",
                    StudyYear = random.Next((i + 1) * 3),
                    Age = random.Next(MINAGE, MAXAGE),
                    Group = $"Group {i + 1}"
                };

                students.Add(course);
            }

            modelBuilder.Entity<Student>().HasData(students);
        }

        private static void SeedTeachers(this ModelBuilder modelBuilder)
        {
            const int QUANTITY = 10;
            const int MINAGE = 18;
            const int MAXAGE = 65;
            List<Teacher> teachers = new List<Teacher>(QUANTITY);

            for (int i = 0; i < QUANTITY; i++)
            {
                var random = new Random();
                var course = new Teacher()
                {
                    Id = Guid.NewGuid(),
                    Name = $"Teacher's name {i + 1}",
                    Surname = $"Teacher's surname {i + 1}",
                    Experience = random.Next((i + 1) * 3),
                    Age = random.Next(MINAGE, MAXAGE)
                };

                teachers.Add(course);
            }

            modelBuilder.Entity<Teacher>().HasData(teachers);
        }
    }
}
