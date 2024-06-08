using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftServe.BLL.Dto.CourseDtos;

namespace TestTaskSoftServe.BLL.Dto.StudentDtos
{
    public record StudentResponseDto(
        Guid Id,
        string Name,
        string Surname,
        int Age,
        int StudyYear,
        string Group,
        List<CourseShortDto>? Courses);
}
