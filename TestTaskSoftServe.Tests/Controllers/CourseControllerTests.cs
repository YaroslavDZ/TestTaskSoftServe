using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using Test_Task_SoftServe.Controllers.Course;
using TestTaskSoftServe.BLL.Dto.CourseDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;

namespace TestTaskSoftServe.Tests.Controllers
{
    public class CourseControllerTests
    {
        private readonly Mock<ICourseService> _courseServiceMock;
        private readonly ICourseService _courseService;
        private readonly CourseController _courseController;
        private readonly IFixture _fixture;

        public CourseControllerTests()
        {
            _fixture = new Fixture();

            _courseServiceMock = new Mock<ICourseService>();
            _courseService = _courseServiceMock.Object;

            _courseController = new CourseController(_courseService);
        }

        [Fact]
        public async Task GetAll_ReturnsOkResult_WithListOfCourses()
        {
            // Arrange
            var courses = new List<CourseResponseDto>
            {
                _fixture.Create<CourseResponseDto>(),
                _fixture.Create<CourseResponseDto>(),
            };

            _courseServiceMock.Setup(service => service.GetAllCourses())
                .ReturnsAsync(courses);

            // Act
            var result = await _courseController.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<CourseResponseDto>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public async Task GetAll_ReturnsNoContent_WhenNoCoursesExist()
        {
            // Arrange
            var courses = new List<CourseResponseDto>();
            _courseServiceMock.Setup(service => service.GetAllCourses())
                .ReturnsAsync(courses);

            // Act
            var result = await _courseController.GetAll();

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsOkResult_WithCourse()
        {
            // Arrange
            var courseId = Guid.NewGuid();
            var course = _fixture.Build<CourseResponseDto>()
                .With(c => c.Id, courseId).Create();
            _courseServiceMock.Setup(service => service.GetCourseById(courseId))
                .ReturnsAsync(course);

            // Act
            var result = await _courseController.GetById(courseId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<CourseResponseDto>(okResult.Value);
            Assert.Equal(courseId, returnValue.Id);
        }

        [Fact]
        public async Task GetById_ReturnsNoContent_WhenCourseNotFound()
        {
            // Arrange
            var courseId = Guid.NewGuid();
            _courseServiceMock.Setup(service => service.GetCourseById(courseId))
                .ReturnsAsync((CourseResponseDto)null);

            // Act
            var result = await _courseController.GetById(courseId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsBadRequest_WhenIdIsNull()
        {
            // Arrange
            Guid? courseId = null;

            // Act
            var result = await _courseController.GetById(courseId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Create_ReturnsCreatedAtActionResult_WithCourse()
        {
            // Arrange
            var courseAddRequestDto = _fixture.Create<CourseAddRequestDto>();
            var courseResponseDto = _fixture.Build<CourseResponseDto>()
                                         .With(s => s.Id, Guid.NewGuid())
                                         .With(s => s.Title, courseAddRequestDto.Title)
                                         .With(s => s.Description, courseAddRequestDto.Description)
                                         .Create();
            _courseServiceMock.Setup(service => service.CreateCourse(courseAddRequestDto))
                .ReturnsAsync(courseResponseDto);

            // Act
            var result = await _courseController.Create(courseAddRequestDto);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<CourseResponseDto>(createdAtActionResult.Value);
            Assert.Equal(courseResponseDto.Id, returnValue.Id);
            Assert.Equal(courseResponseDto.Title, returnValue.Title);
        }

        [Fact]
        public async Task Create_ReturnsBadRequest_WhenRequestIsNull()
        {
            // Arrange
            CourseAddRequestDto? courseAddRequestDto = null;

            // Act
            var result = await _courseController.Create(courseAddRequestDto);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Update_ReturnsOkResult_WithUpdatedCourse()
        {
            // Arrange
            var courseUpdateRequestDto = _fixture.Create<CourseUpdateRequestDto>();
            var courseResponseDto = _fixture.Build<CourseResponseDto>()
                                         .With(s => s.Id, courseUpdateRequestDto.Id)
                                         .With(s => s.Title, courseUpdateRequestDto.Title)
                                         .With(s => s.Description, courseUpdateRequestDto.Description)
                                         .Create();
            _courseServiceMock.Setup(service => service.UpdateCourse(courseUpdateRequestDto))
                .ReturnsAsync(courseResponseDto);

            // Act
            var result = await _courseController.Update(courseUpdateRequestDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<CourseResponseDto>(okResult.Value);
            Assert.Equal(courseResponseDto.Id, returnValue.Id);
            Assert.Equal(courseResponseDto.Title, returnValue.Title);
        }

        [Fact]
        public async Task Update_ReturnsNotFound_WhenCourseNotFound()
        {
            // Arrange
            var courseUpdateRequestDto = _fixture.Create<CourseUpdateRequestDto>();
            _courseServiceMock.Setup(service => service.UpdateCourse(courseUpdateRequestDto))
                .ReturnsAsync((CourseResponseDto)null);

            // Act
            var result = await _courseController.Update(courseUpdateRequestDto);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNoContent_WhenCourseIsDeleted()
        {
            // Arrange
            var courseId = Guid.NewGuid();
            _courseServiceMock.Setup(service => service.DeleteCourseById(courseId))
                .ReturnsAsync(true);

            // Act
            var result = await _courseController.Delete(courseId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNotFound_WhenCourseNotFound()
        {
            // Arrange
            var courseId = Guid.NewGuid();
            _courseServiceMock.Setup(service => service.DeleteCourseById(courseId))
                .ReturnsAsync(false);

            // Act
            var result = await _courseController.Delete(courseId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
