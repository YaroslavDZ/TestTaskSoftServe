using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.CourseDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Courses;

namespace TestTaskSoftServe.BLL.Services.Realizations
{
    public class CourseService : ICourseService
    {
        private readonly ICoursesRepository _coursesRepository;
        private readonly IMapper _mapper;

        public CourseService(ICoursesRepository coursesRepository, IMapper mapper)
        {
            _coursesRepository = coursesRepository;
            _mapper = mapper;
        }

        public async Task<CourseResponseDto> CreateCourse(CourseAddRequestDto? courseAddRequestDto)
        {
            if (courseAddRequestDto is null)
            {
                throw new ArgumentNullException(nameof(courseAddRequestDto), "Course dto is null");
            }

            var course = _mapper.Map<Course>(courseAddRequestDto);

            var createdCourse = await _coursesRepository.CreateAsync(course);

            var response = _mapper.Map<CourseResponseDto>(createdCourse);

            return response;
            
        }

        public async Task<bool> DeleteCourseById(Guid id)
        {
            Course? course = await _coursesRepository.GetByIdAsync(id);

            if (course is null)
            {
                return false;
            }

            await _coursesRepository.DeleteByIdAsync(id);

            return true;
        }

        public async Task<List<CourseResponseDto>> GetAllCourses()
        {
            var courses = await _coursesRepository.GetAllAsync();

            return courses.Select(c => _mapper.Map<CourseResponseDto>(c)).ToList();
        }

        public async Task<List<CourseResponseDto>> GetAllCourses(Expression<Func<Course, bool>> predicate)
        {
            var courses = await _coursesRepository.GetAllAsync(predicate);

            return courses.Select(c => _mapper.Map<CourseResponseDto>(c)).ToList();
        }

        public async Task<CourseResponseDto> GetCourseById(Guid? id)
        {
            if (id is null)
            {
                var message = "Id can't be null";
                throw new ArgumentNullException(nameof(id), message);
            }

            Course? course = await _coursesRepository.GetByIdAsync(id.Value);

            if (course is null)
            {
                var message = $"There is no object by such id: {id}";
                throw new KeyNotFoundException(message);
            }

            return _mapper.Map<CourseResponseDto>(course);
        }

        public async Task<CourseResponseDto> UpdateCourse(CourseUpdateRequestDto? courseUpdateRequestDto)
        {
            if (courseUpdateRequestDto is null)
            {
                var message = "Update dto is null";
                throw new ArgumentNullException(nameof(courseUpdateRequestDto), message);
            }

            var course = _mapper.Map<Course>(courseUpdateRequestDto);

            await _coursesRepository.UpdateAsync(course);

            return _mapper.Map<CourseResponseDto>(course);
        }
    }
}
