using System.ComponentModel.DataAnnotations;

namespace TestTaskSoftserve.DAL.Entities
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public int Age { get; set; }

        public int StudyYear { get; set; }

        public string? Group { get; set; }

        public List<Course>? Courses { get; set; }
    }
}
