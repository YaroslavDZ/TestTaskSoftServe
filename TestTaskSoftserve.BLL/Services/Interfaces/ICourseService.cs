using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.CourseDtos;

namespace TestTaskSoftServe.BLL.Services.Interfaces
{
    public interface ICourseService
    {
        Task<CourseResponseDto> CreateCourse(CourseAddRequestDto? courseAddRequestDto);
        Task<CourseResponseDto> GetCourseById(Guid? id);
        Task<List<CourseResponseDto>> GetAllCourses();
        Task<List<CourseResponseDto>> GetAllCourses(Expression<Func<Course, bool>> predicate);
        Task<bool> DeleteCourseById(Guid id);
        Task<CourseResponseDto> UpdateCourse(CourseUpdateRequestDto? courseUpdateRequestDto);
    }
}
