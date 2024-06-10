using AutoFixture;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftServe.BLL.Dto.StudentDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.BLL.Services.Realizations;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Students;
using Xunit;

namespace TestTaskSoftServe.Tests.Services.StudentServices
{
    public class StudentServiceTests
    {
        private readonly IFixture _fixture;
        private readonly Mock<IStudentsRepository> _mockStudentsRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly Mock<ILogger<StudentService>> _mockLogger;
        private readonly IStudentService _studentService;

        public StudentServiceTests()
        {
            _fixture = new Fixture();
            _mockStudentsRepository = new Mock<IStudentsRepository>();
            _mockMapper = new Mock<IMapper>();
            _mockLogger = new Mock<ILogger<StudentService>>();
            _studentService = new StudentService(_mockStudentsRepository.Object, _mockMapper.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task CreateStudent_ReturnsStudentResponseDto_WhenStudentIsCreated()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            var studentAddRequestDto = _fixture.Create<StudentAddRequestDto>();
            var student = _fixture.Build<Student>()
                                 .With(c => c.Id, Guid.NewGuid())
                                 .With(c => c.Courses, null as List<Course>)
                                 .Create();
            var studentResponseDto = _fixture.Build<StudentResponseDto>()
                                            .With(c => c.Id, studentId)
                                            .Create();

            _mockMapper.Setup(m => m.Map<Student>(studentAddRequestDto)).Returns(student);
            _mockStudentsRepository.Setup(repo => repo.CreateAsync(student)).ReturnsAsync(student);
            _mockMapper.Setup(m => m.Map<StudentResponseDto>(student)).Returns(studentResponseDto);

            // Act
            var result = await _studentService.CreateStudent(studentAddRequestDto);

            // Assert
            Assert.Equal(studentResponseDto.Id, result.Id);
            Assert.Equal(studentResponseDto.Name, result.Name);
        }

        [Fact]
        public async Task CreateStudent_ThrowsArgumentNullException_WhenStudentAddRequestDtoIsNull()
        {
            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _studentService.CreateStudent(null));
            Assert.Equal("studentAddRequestDto", exception.ParamName);
        }

        [Fact]
        public async Task DeleteStudentById_ReturnsTrue_WhenStudentIsDeleted()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            var student = _fixture.Build<Student>()
                .With(c => c.Id, studentId)
                .With(c => c.Courses, null as List<Course>)
                .Create();

            _mockStudentsRepository.Setup(repo => repo.GetByIdAsync(studentId)).ReturnsAsync(student);
            _mockStudentsRepository.Setup(repo => repo.DeleteByIdAsync(studentId)).ReturnsAsync(true);

            // Act
            var result = await _studentService.DeleteStudentById(studentId);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task DeleteStudentById_ReturnsFalse_WhenStudentNotFound()
        {
            // Arrange
            var studentId = Guid.NewGuid();

            _mockStudentsRepository.Setup(repo => repo.GetByIdAsync(studentId)).ReturnsAsync((Student)null);

            // Act
            var result = await _studentService.DeleteStudentById(studentId);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task GetAllStudents_ReturnsListOfStudentResponseDto_WhenStudentsExist()
        {
            // Arrange
            var students = new List<Student>(5);
            for (int i = 0; i < 5; i++)
            {
                var student = _fixture.Build<Student>()
                .With(c => c.Courses, null as List<Course>)
                .Create();

                students.Add(student);
            }
            var studentResponseDtos = students.Select(c => _fixture.Build<StudentResponseDto>().With(crd => crd.Id, c.Id).Create()).ToList();

            _mockStudentsRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(students);
            _mockMapper.Setup(m => m.Map<StudentResponseDto>(It.IsAny<Student>()))
                       .Returns((Student student) => new StudentResponseDto(
                           student.Id, student.Name, student.Surname, student.Age, student.StudyYear,
                           student.Group, null));

            // Act
            var result = await _studentService.GetAllStudents();

            // Assert
            Assert.Equal(studentResponseDtos.Count, result.Count);
        }

        [Fact]
        public async Task GetAllStudents_ReturnsEmptyList_WhenNoStudentsExist()
        {
            // Arrange
            var students = new List<Student>();

            _mockStudentsRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(students);

            // Act
            var result = await _studentService.GetAllStudents();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetStudentById_ReturnsStudentResponseDto_WhenStudentExists()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            var student = _fixture.Build<Student>().With(c => c.Id, studentId)
                .With(c => c.Courses, null as List<Course>)
                .Create();
            var studentResponseDto = _fixture.Build<StudentResponseDto>().With(crd => crd.Id, student.Id).Create();

            _mockStudentsRepository.Setup(repo => repo.GetByIdAsync(studentId)).ReturnsAsync(student);
            _mockMapper.Setup(m => m.Map<StudentResponseDto>(student)).Returns(studentResponseDto);

            // Act
            var result = await _studentService.GetStudentById(studentId);

            // Assert
            Assert.Equal(studentResponseDto.Id, result.Id);
            Assert.Equal(studentResponseDto.Name, result.Name);
        }

        [Fact]
        public async Task GetStudentById_ThrowsArgumentNullException_WhenIdIsNull()
        {
            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _studentService.GetStudentById(null));
            Assert.Equal("id", exception.ParamName);
        }

        [Fact]
        public async Task GetStudentById_ThrowsKeyNotFoundException_WhenStudentNotFound()
        {
            // Arrange
            var studentId = Guid.NewGuid();

            _mockStudentsRepository.Setup(repo => repo.GetByIdAsync(studentId)).ReturnsAsync((Student)null);

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(() => _studentService.GetStudentById(studentId));
        }
    }
}
