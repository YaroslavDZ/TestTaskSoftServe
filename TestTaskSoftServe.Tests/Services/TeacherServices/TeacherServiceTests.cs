using AutoFixture;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using TestTaskSoftServe.BLL.Dto.TeacherDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.BLL.Services.Realizations;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Teachers;
using Xunit;

namespace TestTaskSoftServe.Tests.Services.TeacherServices
{
    public class TeacherServiceTests
    {
        private readonly IFixture _fixture;
        private readonly Mock<ITeachersRepository> _mockTeachersRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly Mock<ILogger<TeacherService>> _mockLogger;
        private readonly ITeacherService _teacherService;

        public TeacherServiceTests()
        {
            _fixture = new Fixture();
            _mockTeachersRepository = new Mock<ITeachersRepository>();
            _mockMapper = new Mock<IMapper>();
            _mockLogger = new Mock<ILogger<TeacherService>>();
            _teacherService = new TeacherService(_mockTeachersRepository.Object,
                _mockMapper.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task CreateTeacher_ReturnsTeacherResponseDto_WhenTeacherIsCreated()
        {
            // Arrange
            var teacherId = Guid.NewGuid();
            var teacherAddRequestDto = _fixture.Create<TeacherAddRequestDto>();
            var teacher = _fixture.Build<Teacher>()
                                 .With(c => c.Id, Guid.NewGuid())
                                 .With(c => c.Courses, null as List<Course>)
                                 .Create();
            var teacherResponseDto = _fixture.Build<TeacherResponseDto>()
                                            .With(c => c.Id, teacherId)
                                            .Create();

            _mockMapper.Setup(m => m.Map<Teacher>(teacherAddRequestDto)).Returns(teacher);
            _mockTeachersRepository.Setup(repo => repo.CreateAsync(teacher)).ReturnsAsync(teacher);
            _mockMapper.Setup(m => m.Map<TeacherResponseDto>(teacher)).Returns(teacherResponseDto);

            // Act
            var result = await _teacherService.CreateTeacher(teacherAddRequestDto);

            // Assert
            Assert.Equal(teacherResponseDto.Id, result.Id);
            Assert.Equal(teacherResponseDto.Name, result.Name);
        }

        [Fact]
        public async Task CreateTeacher_ThrowsArgumentNullException_WhenTeacherAddRequestDtoIsNull()
        {
            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() =>
                _teacherService.CreateTeacher(null));
            Assert.Equal("teacherAddRequestDto", exception.ParamName);
        }

        [Fact]
        public async Task DeleteTeacherById_ReturnsTrue_WhenTeacherIsDeleted()
        {
            // Arrange
            var teacherId = Guid.NewGuid();
            var teacher = _fixture.Build<Teacher>()
                .With(c => c.Id, teacherId)
                .With(c => c.Courses, null as List<Course>)
                .Create();

            _mockTeachersRepository.Setup(repo => repo.GetByIdAsync(teacherId)).ReturnsAsync(teacher);
            _mockTeachersRepository.Setup(repo => repo.DeleteByIdAsync(teacherId)).ReturnsAsync(true);

            // Act
            var result = await _teacherService.DeleteTeacherById(teacherId);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task DeleteTeacherById_ReturnsFalse_WhenTeacherNotFound()
        {
            // Arrange
            var teacherId = Guid.NewGuid();

            _mockTeachersRepository.Setup(repo => repo.GetByIdAsync(teacherId))
                .ReturnsAsync((Teacher)null);

            // Act
            var result = await _teacherService.DeleteTeacherById(teacherId);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task GetAllTeachers_ReturnsListOfTeacherResponseDto_WhenTeachersExist()
        {
            // Arrange
            var teachers = new List<Teacher>(5);
            for (int i = 0; i < 5; i++)
            {
                var teacher = _fixture.Build<Teacher>()
                .With(c => c.Courses, null as List<Course>)
                .Create();

                teachers.Add(teacher);
            }
            var teacherResponseDtos = teachers.Select(c => _fixture.Build<TeacherResponseDto>()
                .With(crd => crd.Id, c.Id).Create()).ToList();

            _mockTeachersRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(teachers);
            _mockMapper.Setup(m => m.Map<TeacherResponseDto>(It.IsAny<Teacher>()))
                       .Returns((Teacher teacher) => new TeacherResponseDto(
                           teacher.Id, teacher.Name, teacher.Surname, teacher.Age,
                           teacher.Experience, null));

            // Act
            var result = await _teacherService.GetAllTeachers();

            // Assert
            Assert.Equal(teacherResponseDtos.Count, result.Count);
        }

        [Fact]
        public async Task GetAllTeachers_ReturnsEmptyList_WhenNoTeachersExist()
        {
            // Arrange
            var teachers = new List<Teacher>();

            _mockTeachersRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(teachers);

            // Act
            var result = await _teacherService.GetAllTeachers();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetTeacherById_ReturnsTeacherResponseDto_WhenTeacherExists()
        {
            // Arrange
            var teacherId = Guid.NewGuid();
            var teacher = _fixture.Build<Teacher>().With(c => c.Id, teacherId)
                .With(c => c.Courses, null as List<Course>)
                .Create();
            var teacherResponseDto = _fixture.Build<TeacherResponseDto>()
                .With(crd => crd.Id, teacher.Id).Create();

            _mockTeachersRepository.Setup(repo => repo.GetByIdAsync(teacherId)).ReturnsAsync(teacher);
            _mockMapper.Setup(m => m.Map<TeacherResponseDto>(teacher)).Returns(teacherResponseDto);

            // Act
            var result = await _teacherService.GetTeacherById(teacherId);

            // Assert
            Assert.Equal(teacherResponseDto.Id, result.Id);
            Assert.Equal(teacherResponseDto.Name, result.Name);
        }

        [Fact]
        public async Task GetTeacherById_ThrowsArgumentNullException_WhenIdIsNull()
        {
            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() =>
            _teacherService.GetTeacherById(null));
            Assert.Equal("id", exception.ParamName);
        }

        [Fact]
        public async Task GetTeacherById_ThrowsKeyNotFoundException_WhenTeacherNotFound()
        {
            // Arrange
            var teacherId = Guid.NewGuid();

            _mockTeachersRepository.Setup(repo => repo.GetByIdAsync(teacherId))
                .ReturnsAsync((Teacher)null);

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(() =>
            _teacherService.GetTeacherById(teacherId));
        }
    }
}
