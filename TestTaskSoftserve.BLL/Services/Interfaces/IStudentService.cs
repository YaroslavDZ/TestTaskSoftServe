using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftServe.BLL.Dto.CourseDtos;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.StudentDtos;

namespace TestTaskSoftServe.BLL.Services.Interfaces
{
    public interface IStudentService
    {
        Task<StudentResponseDto> CreateStudent(StudentAddRequestDto? studentAddRequestDto);
        Task<StudentResponseDto> GetStudentById(Guid? id);
        Task<List<StudentResponseDto>> GetAllStudents();
        Task<List<Student>> GetAllStudentsByIds(List<Guid> ids);
        Task<bool> DeleteStudentById(Guid id);
        Task<StudentResponseDto> UpdateStudent(StudentUpdateRequestDto? studentUpdateRequestDto);
    }
}
