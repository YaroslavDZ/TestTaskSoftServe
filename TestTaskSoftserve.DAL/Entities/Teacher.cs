using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSoftserve.DAL.Entities
{
    public class Teacher
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public int Age { get; set; }

        public int Experience { get; set; }

        public List<Course>? Courses { get; set; }
    }
}
