using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftServe.BLL.Dto.StudentDtos;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.TeacherDtos;

namespace TestTaskSoftServe.BLL.Services.Interfaces
{
    public interface ITeacherService
    {
        Task<TeacherResponseDto> CreateTeacher(TeacherAddRequestDto? teacherAddRequestDto);
        Task<TeacherResponseDto> GetTeacherById(Guid? id);
        Task<List<TeacherResponseDto>> GetAllTeachers();
        Task<bool> DeleteTeacherById(Guid id);
        Task<TeacherResponseDto> UpdateTeacher(TeacherUpdateRequestDto? teacherUpdateRequestDto);
    }
}
