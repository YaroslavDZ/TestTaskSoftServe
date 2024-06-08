using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftServe.BLL.Dto.StudentDtos;
using TestTaskSoftServe.BLL.Dto.TeacherDtos;

namespace TestTaskSoftServe.BLL.Dto.CourseDtos
{
    public record CourseResponseDto(
        Guid Id,
        string Title,
        string Description,
        List<TeacherShortDto>? Teachers,
        List<StudentShortDto>? Students);
}
