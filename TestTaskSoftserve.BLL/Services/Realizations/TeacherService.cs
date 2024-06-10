using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Data;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.TeacherDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Teachers;

namespace TestTaskSoftServe.BLL.Services.Realizations
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeachersRepository _teachersRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<TeacherService> _logger;

        public TeacherService(ITeachersRepository teachersRepository, IMapper mapper,
            ILogger<TeacherService> logger)
        {
            _teachersRepository = teachersRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<TeacherResponseDto> CreateTeacher(TeacherAddRequestDto? teacherAddRequestDto)
        {
            if (teacherAddRequestDto is null)
            {
                var message = "TeacherAddRequestDto is null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(teacherAddRequestDto), message);
            }

            _logger.LogInformation("The Teacher creating was started.");

            var teacher = _mapper.Map<Teacher>(teacherAddRequestDto);

            var createdTeacher = await _teachersRepository.CreateAsync(teacher);

            var result = _mapper.Map<TeacherResponseDto>(createdTeacher);

            _logger.LogInformation($"The Teacher with id {createdTeacher.Id} was created successfully.");

            return result;
        }

        public async Task<bool> DeleteTeacherById(Guid id)
        {
            _logger.LogInformation($"Deleting Teacher with Id = {id} was started.");

            Teacher? teacher = await _teachersRepository.GetByIdAsync(id);

            if (teacher is null)
            {
                _logger.LogInformation($"Teacher with Id = {id} wasn't found.");
                return false;
            }

            try
            {
                await _teachersRepository.DeleteByIdAsync(id);
                _logger.LogInformation($"The Teacher with Id = {id} was successfully deleted.");
            }
            catch (DBConcurrencyException)
            {
                _logger.LogError($"Deleting Teacher with Id = {id} was failed.");
                throw;
            }

            return true;
        }

        public async Task<List<TeacherResponseDto>> GetAllTeachers()
        {
            _logger.LogInformation("Getting all Teachers was started.");

            var teachers = await _teachersRepository.GetAllAsync();

            _logger.LogInformation(!teachers.Any()
            ? "The Teacher table is empty."
            : $"All {teachers.Count()} records were successfully received from the Teacher table");

            return teachers.Select(t => _mapper.Map<TeacherResponseDto>(t)).ToList();
        }

        public async Task<TeacherResponseDto> GetTeacherById(Guid? id)
        {
            _logger.LogInformation($"Getting Teacher by Id was started. Looking Id = {id}.");

            if (id is null)
            {
                var message = "Teacher Id can't be null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(id), message);
            }

            Teacher? teacher = await _teachersRepository.GetByIdAsync(id.Value);

            if (teacher is null)
            {
                var message = $"There is no object by such id: {id}";
                _logger.LogError(message);
                throw new KeyNotFoundException(message);
            }

            _logger.LogInformation($"Got a Teacher with Id = {id}.");

            return _mapper.Map<TeacherResponseDto>(teacher);
        }

        public async Task<TeacherResponseDto> UpdateTeacher(TeacherUpdateRequestDto? teacherUpdateRequestDto)
        {
            if (teacherUpdateRequestDto is null)
            {
                var message = "TeacherUpdateRequestDto is null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(teacherUpdateRequestDto), message);
            }

            _logger.LogInformation($"Updating Teacher with Id = {teacherUpdateRequestDto.Id} was started.");


            var teacher = _mapper.Map<Teacher>(teacherUpdateRequestDto);

            await _teachersRepository.UpdateAsync(teacher);

            var result = _mapper.Map<TeacherResponseDto>(teacher);

            _logger.LogInformation($"The Teacher with Id = {teacherUpdateRequestDto.Id} was updated.");

            return result;
        }
    }
}
