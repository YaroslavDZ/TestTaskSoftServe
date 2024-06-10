using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using Test_Task_SoftServe.Controllers.Teacher;
using TestTaskSoftServe.BLL.Dto.TeacherDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;

namespace TestTaskSoftServe.Tests.Controllers
{
    public class TeacherControllerTests
    {
        private readonly Mock<ITeacherService> _teacherServiceMock;
        private readonly ITeacherService _teacherService;
        private readonly TeacherController _teacherController;
        private readonly IFixture _fixture;

        public TeacherControllerTests()
        {
            _fixture = new Fixture();

            _teacherServiceMock = new Mock<ITeacherService>();
            _teacherService = _teacherServiceMock.Object;

            _teacherController = new TeacherController(_teacherService);
        }

        [Fact]
        public async Task GetAll_ReturnsOkResult_WithListOfTeachers()
        {
            // Arrange
            var teachers = new List<TeacherResponseDto>
            {
                _fixture.Create<TeacherResponseDto>(),
                _fixture.Create<TeacherResponseDto>(),
            };

            _teacherServiceMock.Setup(service => service.GetAllTeachers())
                .ReturnsAsync(teachers);

            // Act
            var result = await _teacherController.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<TeacherResponseDto>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public async Task GetAll_ReturnsNoContent_WhenNoTeachersExist()
        {
            // Arrange
            var teachers = new List<TeacherResponseDto>();
            _teacherServiceMock.Setup(service => service.GetAllTeachers())
                .ReturnsAsync(teachers);

            // Act
            var result = await _teacherController.GetAll();

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsOkResult_WithTeacher()
        {
            // Arrange
            var teacherId = Guid.NewGuid();
            var teacher = _fixture.Build<TeacherResponseDto>()
                .With(t => t.Id, teacherId).Create();
            _teacherServiceMock.Setup(service => service.GetTeacherById(teacherId))
                .ReturnsAsync(teacher);

            // Act
            var result = await _teacherController.GetById(teacherId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<TeacherResponseDto>(okResult.Value);
            Assert.Equal(teacherId, returnValue.Id);
        }

        [Fact]
        public async Task GetById_ReturnsNoContent_WhenTeacherNotFound()
        {
            // Arrange
            var teacherId = Guid.NewGuid();
            _teacherServiceMock.Setup(service => service.GetTeacherById(teacherId))
                .ReturnsAsync((TeacherResponseDto)null);

            // Act
            var result = await _teacherController.GetById(teacherId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsBadRequest_WhenIdIsNull()
        {
            // Arrange
            Guid? teacherId = null;

            // Act
            var result = await _teacherController.GetById(teacherId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Create_ReturnsCreatedAtActionResult_WithTeacher()
        {
            // Arrange
            var teacherAddRequestDto = _fixture.Create<TeacherAddRequestDto>();
            var teacherResponseDto = _fixture.Build<TeacherResponseDto>()
                                         .With(s => s.Id, Guid.NewGuid())
                                         .With(s => s.Name, teacherAddRequestDto.Name)
                                         .With(s => s.Surname, teacherAddRequestDto.Surname)
                                         .With(s => s.Experience, teacherAddRequestDto.Experience)
                                         .With(s => s.Age, teacherAddRequestDto.Age)
                                         .Create();
            _teacherServiceMock.Setup(service => service.CreateTeacher(teacherAddRequestDto))
                .ReturnsAsync(teacherResponseDto);

            // Act
            var result = await _teacherController.Create(teacherAddRequestDto);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<TeacherResponseDto>(createdAtActionResult.Value);
            Assert.Equal(teacherResponseDto.Id, returnValue.Id);
            Assert.Equal(teacherResponseDto.Name, returnValue.Name);
        }

        [Fact]
        public async Task Create_ReturnsBadRequest_WhenRequestIsNull()
        {
            // Arrange
            TeacherAddRequestDto? teacherAddRequestDto = null;

            // Act
            var result = await _teacherController.Create(teacherAddRequestDto);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Update_ReturnsOkResult_WithUpdatedTeacher()
        {
            // Arrange
            var teacherUpdateRequestDto = _fixture.Create<TeacherUpdateRequestDto>();
            var teacherResponseDto = _fixture.Build<TeacherResponseDto>()
                                         .With(s => s.Id, teacherUpdateRequestDto.Id)
                                         .With(s => s.Name, teacherUpdateRequestDto.Name)
                                         .With(s => s.Surname, teacherUpdateRequestDto.Surname)
                                         .With(s => s.Experience, teacherUpdateRequestDto.Experience)
                                         .With(s => s.Age, teacherUpdateRequestDto.Age)
                                         .Create();
            _teacherServiceMock.Setup(service => service.UpdateTeacher(teacherUpdateRequestDto))
                .ReturnsAsync(teacherResponseDto);

            // Act
            var result = await _teacherController.Update(teacherUpdateRequestDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<TeacherResponseDto>(okResult.Value);
            Assert.Equal(teacherResponseDto.Id, returnValue.Id);
            Assert.Equal(teacherResponseDto.Name, returnValue.Name);
        }

        [Fact]
        public async Task Update_ReturnsNotFound_WhenTeacherNotFound()
        {
            // Arrange
            var teacherUpdateRequestDto = _fixture.Create<TeacherUpdateRequestDto>();
            _teacherServiceMock.Setup(service => service.UpdateTeacher(teacherUpdateRequestDto))
                .ReturnsAsync((TeacherResponseDto)null);

            // Act
            var result = await _teacherController.Update(teacherUpdateRequestDto);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNoContent_WhenTeacherIsDeleted()
        {
            // Arrange
            var teacherId = Guid.NewGuid();
            _teacherServiceMock.Setup(service => service.DeleteTeacherById(teacherId))
                .ReturnsAsync(true);

            // Act
            var result = await _teacherController.Delete(teacherId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNotFound_WhenTeacherNotFound()
        {
            // Arrange
            var teacherId = Guid.NewGuid();
            _teacherServiceMock.Setup(service => service.DeleteTeacherById(teacherId))
                .ReturnsAsync(false);

            // Act
            var result = await _teacherController.Delete(teacherId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
