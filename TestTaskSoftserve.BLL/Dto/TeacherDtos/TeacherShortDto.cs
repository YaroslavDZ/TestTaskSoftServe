﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSoftServe.BLL.Dto.TeacherDtos
{
    public record TeacherShortDto(
        string Name,
        string Surname,
        int Age,
        int Experience);
}
