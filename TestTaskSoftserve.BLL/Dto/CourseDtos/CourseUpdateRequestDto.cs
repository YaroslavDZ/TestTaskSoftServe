using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSoftServe.BLL.Dto.CourseDtos
{
    public record CourseUpdateRequestDto(
        Guid Id,
        string Title,
        string Description,
        List<Guid>? TeachersIds,
        List<Guid>? StudentsIds);
}
