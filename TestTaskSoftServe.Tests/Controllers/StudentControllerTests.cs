using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using Test_Task_SoftServe.Controllers.Student;
using TestTaskSoftServe.BLL.Dto.StudentDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;

namespace TestTaskSoftServe.Tests.Controllers
{
    public class StudentControllerTests
    {
        private readonly Mock<IStudentService> _studentServiceMock;
        private readonly IStudentService _studentService;
        private readonly StudentController _studentController;
        private readonly IFixture _fixture;

        public StudentControllerTests()
        {
            _fixture = new Fixture();

            _studentServiceMock = new Mock<IStudentService>();
            _studentService = _studentServiceMock.Object;

            _studentController = new StudentController(_studentService);
        }

        [Fact]
        public async Task GetAll_ReturnsOkResult_WithListOfStudents()
        {
            // Arrange
            var students = new List<StudentResponseDto>
            {
                _fixture.Create<StudentResponseDto>(),
                _fixture.Create<StudentResponseDto>(),
            };

            _studentServiceMock.Setup(service => service.GetAllStudents())
                .ReturnsAsync(students);

            // Act
            var result = await _studentController.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<StudentResponseDto>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public async Task GetAll_ReturnsNoContent_WhenNoStudentsExist()
        {
            // Arrange
            var students = new List<StudentResponseDto>();
            _studentServiceMock.Setup(service => service.GetAllStudents())
                .ReturnsAsync(students);

            // Act
            var result = await _studentController.GetAll();

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsOkResult_WithStudent()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            var student = _fixture.Build<StudentResponseDto>()
                .With(s => s.Id, studentId).Create();
            _studentServiceMock.Setup(service => service.GetStudentById(studentId))
                .ReturnsAsync(student);

            // Act
            var result = await _studentController.GetById(studentId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<StudentResponseDto>(okResult.Value);
            Assert.Equal(studentId, returnValue.Id);
        }

        [Fact]
        public async Task GetById_ReturnsNoContent_WhenStudentNotFound()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            _studentServiceMock.Setup(service => service.GetStudentById(studentId))
                .ReturnsAsync((StudentResponseDto)null);

            // Act
            var result = await _studentController.GetById(studentId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsBadRequest_WhenIdIsNull()
        {
            // Arrange
            Guid? studentId = null;

            // Act
            var result = await _studentController.GetById(studentId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Create_ReturnsCreatedAtActionResult_WithStudent()
        {
            // Arrange
            var studentAddRequestDto = _fixture.Create<StudentAddRequestDto>();
            var studentResponseDto = _fixture.Build<StudentResponseDto>()
                                         .With(s => s.Id, Guid.NewGuid())
                                         .With(s => s.Name, studentAddRequestDto.Name)
                                         .With(s => s.Surname, studentAddRequestDto.Surname)
                                         .With(s => s.StudyYear, studentAddRequestDto.StudyYear)
                                         .With(s => s.Age, studentAddRequestDto.Age)
                                         .With(s => s.Group, studentAddRequestDto.Group)
                                         .Create();
            _studentServiceMock.Setup(service => service.CreateStudent(studentAddRequestDto))
                .ReturnsAsync(studentResponseDto);

            // Act
            var result = await _studentController.Create(studentAddRequestDto);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<StudentResponseDto>(createdAtActionResult.Value);
            Assert.Equal(studentResponseDto.Id, returnValue.Id);
            Assert.Equal(studentResponseDto.Name, returnValue.Name);
        }

        [Fact]
        public async Task Create_ReturnsBadRequest_WhenRequestIsNull()
        {
            // Arrange
            StudentAddRequestDto? studentAddRequestDto = null;

            // Act
            var result = await _studentController.Create(studentAddRequestDto);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Update_ReturnsOkResult_WithUpdatedStudent()
        {
            // Arrange
            var studentUpdateRequestDto = _fixture.Create<StudentUpdateRequestDto>();
            var studentResponseDto = _fixture.Build<StudentResponseDto>()
                                         .With(s => s.Id, studentUpdateRequestDto.Id)
                                         .With(s => s.Name, studentUpdateRequestDto.Name)
                                         .With(s => s.Surname, studentUpdateRequestDto.Surname)
                                         .With(s => s.StudyYear, studentUpdateRequestDto.StudyYear)
                                         .With(s => s.Age, studentUpdateRequestDto.Age)
                                         .With(s => s.Group, studentUpdateRequestDto.Group)
                                         .Create();
            _studentServiceMock.Setup(service => service.UpdateStudent(studentUpdateRequestDto))
                .ReturnsAsync(studentResponseDto);

            // Act
            var result = await _studentController.Update(studentUpdateRequestDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<StudentResponseDto>(okResult.Value);
            Assert.Equal(studentResponseDto.Id, returnValue.Id);
            Assert.Equal(studentResponseDto.Name, returnValue.Name);
        }

        [Fact]
        public async Task Update_ReturnsNotFound_WhenStudentNotFound()
        {
            // Arrange
            var studentUpdateRequestDto = _fixture.Create<StudentUpdateRequestDto>();
            _studentServiceMock.Setup(service => service.UpdateStudent(studentUpdateRequestDto))
                .ReturnsAsync((StudentResponseDto)null);

            // Act
            var result = await _studentController.Update(studentUpdateRequestDto);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNoContent_WhenStudentIsDeleted()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            _studentServiceMock.Setup(service => service.DeleteStudentById(studentId))
                .ReturnsAsync(true);

            // Act
            var result = await _studentController.Delete(studentId);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNotFound_WhenStudentNotFound()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            _studentServiceMock.Setup(service => service.DeleteStudentById(studentId))
                .ReturnsAsync(false);

            // Act
            var result = await _studentController.Delete(studentId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}