using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<CourseService> _logger;

        public CourseService(ICoursesRepository coursesRepository, IMapper mapper,
            ILogger<CourseService> logger)
        {
            _coursesRepository = coursesRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CourseResponseDto> CreateCourse(CourseAddRequestDto? courseAddRequestDto)
        {
            if (courseAddRequestDto is null)
            {
                var message = "CourseAddRequest dto is null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(courseAddRequestDto), message);
            }

            _logger.LogInformation("The course creating was started.");

            var course = _mapper.Map<Course>(courseAddRequestDto);
            course.Id = Guid.NewGuid();

            var createdCourse = await _coursesRepository.CreateAsync(course).ConfigureAwait(false);

            var response = _mapper.Map<CourseResponseDto>(createdCourse);

            _logger.LogInformation($"The course with id {createdCourse.Id} was created successfully.");

            return response;
            
        }

        public async Task<bool> DeleteCourseById(Guid id)
        {
            _logger.LogInformation($"Deleting Course with Id = {id} was started.");

            Course? course = await _coursesRepository.GetByIdAsync(id).ConfigureAwait(false);

            if (course is null)
            {
                _logger.LogInformation($"Course with Id = {id} wasn't found.");
                return false;
            }

            try
            {
                await _coursesRepository.DeleteByIdAsync(id).ConfigureAwait(false);
                _logger.LogInformation($"The Course with Id = {id} was successfully deleted.");
            }
            catch (DbUpdateConcurrencyException)
            {
                _logger.LogError($"Deleting Course with Id = {id} was failed.");
                throw;
            }

            return true;
        }

        public async Task<List<CourseResponseDto>> GetAllCourses()
        {
            _logger.LogInformation("Getting all Courses started.");

            var courses = await _coursesRepository.GetAllAsync().ConfigureAwait(false);

            _logger.LogInformation(!courses.Any()
            ? "Course table is empty."
            : $"All {courses.Count()} records were successfully received from the Course table");

            return courses.Select(c => _mapper.Map<CourseResponseDto>(c)).ToList();
        }

        public async Task<CourseResponseDto> GetCourseById(Guid? id)
        {
            _logger.LogInformation($"Getting Course by Id started. Looking Id = {id}.");

            if (id is null)
            {
                var message = "Course id can't be null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(id), message);
            }

            Course? course = await _coursesRepository.GetByIdAsync(id.Value).ConfigureAwait(false);

            if (course is null)
            {
                var message = $"There is no object by such id: {id}";
                _logger.LogError(message);
                throw new KeyNotFoundException(message);
            }

            _logger.LogInformation($"Got a course with Id = {id}.");

            return _mapper.Map<CourseResponseDto>(course);
        }

        public async Task<CourseResponseDto> UpdateCourse(CourseUpdateRequestDto? courseUpdateRequestDto)
        {
            if (courseUpdateRequestDto is null)
            {
                var message = "CourseUpdateRequestDto is null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(courseUpdateRequestDto), message);
            }

            _logger.LogInformation($"Updating Course with Id = {courseUpdateRequestDto.Id} was started.");

            var course = _mapper.Map<Course>(courseUpdateRequestDto);

            await _coursesRepository.UpdateAsync(course).ConfigureAwait(false);

            var result = _mapper.Map<CourseResponseDto>(course);

            _logger.LogInformation($"The course with Id = {courseUpdateRequestDto.Id} was updated.");

            return result;
        }
    }
}
