using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSoftServe.BLL.Dto.StudentDtos
{
    public record StudentShortDto(
        string Name,
        string Surname,
        int Age,
        int StudyYear,
        string Group);
}
