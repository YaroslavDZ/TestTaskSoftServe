using AutoFixture;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.CourseDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.BLL.Services.Realizations;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Courses;
using Xunit;

namespace TestTaskSoftServe.Tests.Services.CourseServices
{
    public class CourseServiceTests
    {
        private readonly IFixture _fixture;
        private readonly Mock<ICoursesRepository> _mockCoursesRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly Mock<ILogger<CourseService>> _mockLogger;
        private readonly ICourseService _courseService;

        public CourseServiceTests()
        {
            _fixture = new Fixture();
            _mockCoursesRepository = new Mock<ICoursesRepository>();
            _mockMapper = new Mock<IMapper>();
            _mockLogger = new Mock<ILogger<CourseService>>();
            _courseService = new CourseService(_mockCoursesRepository.Object, _mockMapper.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task CreateCourse_ReturnsCourseResponseDto_WhenCourseIsCreated()
        {
            // Arrange
            var courseId = Guid.NewGuid();
            var courseAddRequestDto = _fixture.Create<CourseAddRequestDto>();
            var course = _fixture.Build<Course>()
                                 .With(c => c.Id, Guid.NewGuid())
                                 .With(c => c.Students, null as List<Student>)
                                 .With(c => c.Teachers, null as List<Teacher>)
                                 .Create();
            var courseResponseDto = _fixture.Build<CourseResponseDto>()
                                            .With(c => c.Id, courseId)
                                            .Create();

            _mockMapper.Setup(m => m.Map<Course>(courseAddRequestDto)).Returns(course);
            _mockCoursesRepository.Setup(repo => repo.CreateAsync(course)).ReturnsAsync(course);
            _mockMapper.Setup(m => m.Map<CourseResponseDto>(course)).Returns(courseResponseDto);

            // Act
            var result = await _courseService.CreateCourse(courseAddRequestDto);

            // Assert
            Assert.Equal(courseResponseDto.Id, result.Id);
            Assert.Equal(courseResponseDto.Title, result.Title);
        }

        [Fact]
        public async Task CreateCourse_ThrowsArgumentNullException_WhenCourseAddRequestDtoIsNull()
        {
            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _courseService.CreateCourse(null));
            Assert.Equal("courseAddRequestDto", exception.ParamName);
        }

        [Fact]
        public async Task DeleteCourseById_ReturnsTrue_WhenCourseIsDeleted()
        {
            // Arrange
            var courseId = Guid.NewGuid();
            var course = _fixture.Build<Course>()
                .With(c => c.Id, courseId)
                .With(c => c.Students, null as List<Student>)
                .With(c => c.Teachers, null as List<Teacher>)
                .Create();

            _mockCoursesRepository.Setup(repo => repo.GetByIdAsync(courseId)).ReturnsAsync(course);
            _mockCoursesRepository.Setup(repo => repo.DeleteByIdAsync(courseId)).ReturnsAsync(true);

            // Act
            var result = await _courseService.DeleteCourseById(courseId);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task DeleteCourseById_ReturnsFalse_WhenCourseNotFound()
        {
            // Arrange
            var courseId = Guid.NewGuid();

            _mockCoursesRepository.Setup(repo => repo.GetByIdAsync(courseId)).ReturnsAsync((Course)null);

            // Act
            var result = await _courseService.DeleteCourseById(courseId);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task GetAllCourses_ReturnsListOfCourseResponseDto_WhenCoursesExist()
        {
            // Arrange
            var courses = new List<Course>(5);
            for (int i = 0; i < 5; i++)
            {
                var course = _fixture.Build<Course>()
                .With(c => c.Students, null as List<Student>)
                .With(c => c.Teachers, null as List<Teacher>)
                .Create();

                courses.Add(course);
            }
            var courseResponseDtos = courses.Select(c => _fixture.Build<CourseResponseDto>().With(crd => crd.Id, c.Id).Create()).ToList();

            _mockCoursesRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(courses);
            _mockMapper.Setup(m => m.Map<CourseResponseDto>(It.IsAny<Course>()))
                       .Returns((Course course) => new CourseResponseDto(
                           course.Id, course.Title, course.Description, null, null));

            // Act
            var result = await _courseService.GetAllCourses();

            // Assert
            Assert.Equal(courseResponseDtos.Count, result.Count);
        }

        [Fact]
        public async Task GetAllCourses_ReturnsEmptyList_WhenNoCoursesExist()
        {
            // Arrange
            var courses = new List<Course>();

            _mockCoursesRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(courses);

            // Act
            var result = await _courseService.GetAllCourses();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetCourseById_ReturnsCourseResponseDto_WhenCourseExists()
        {
            // Arrange
            var courseId = Guid.NewGuid();
            var course = _fixture.Build<Course>().With(c => c.Id, courseId)
                .With(c => c.Students, null as List<Student>)
                .With(c => c.Teachers, null as List<Teacher>)
                .Create();
            var courseResponseDto = _fixture.Build<CourseResponseDto>().With(crd => crd.Id, course.Id).Create();

            _mockCoursesRepository.Setup(repo => repo.GetByIdAsync(courseId)).ReturnsAsync(course);
            _mockMapper.Setup(m => m.Map<CourseResponseDto>(course)).Returns(courseResponseDto);

            // Act
            var result = await _courseService.GetCourseById(courseId);

            // Assert
            Assert.Equal(courseResponseDto.Id, result.Id);
            Assert.Equal(courseResponseDto.Title, result.Title);
        }

        [Fact]
        public async Task GetCourseById_ThrowsArgumentNullException_WhenIdIsNull()
        {
            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _courseService.GetCourseById(null));
            Assert.Equal("id", exception.ParamName);
        }

        [Fact]
        public async Task GetCourseById_ThrowsKeyNotFoundException_WhenCourseNotFound()
        {
            // Arrange
            var courseId = Guid.NewGuid();

            _mockCoursesRepository.Setup(repo => repo.GetByIdAsync(courseId)).ReturnsAsync((Course)null);

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(() => _courseService.GetCourseById(courseId));
        }
    }
}
