using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftServe.BLL.Dto.CourseDtos;

namespace TestTaskSoftServe.BLL.Dto.TeacherDtos
{
    public record TeacherResponseDto(
        Guid Id,
        string Name,
        string Surname,
        int Age,
        int Experience,
        List<CourseShortDto>? Courses);
}
