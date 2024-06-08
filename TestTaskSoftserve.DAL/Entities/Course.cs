using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSoftserve.DAL.Entities
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public List<Student>? Students { get; set; }

        public List<Teacher>? Teachers { get; set; }
    }
}
