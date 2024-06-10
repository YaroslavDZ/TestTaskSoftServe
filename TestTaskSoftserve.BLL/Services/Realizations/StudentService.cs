using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.CourseDtos;
using TestTaskSoftServe.BLL.Dto.StudentDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Students;

namespace TestTaskSoftServe.BLL.Services.Realizations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<StudentService> _logger;

        public StudentService(IStudentsRepository studentsRepository, IMapper mapper,
            ILogger<StudentService> logger)
        {
            _studentsRepository = studentsRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<StudentResponseDto> CreateStudent(StudentAddRequestDto? studentAddRequestDto)
        {
            if (studentAddRequestDto is null)
            {
                var message = "StudentAddRequestDto dto is null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(studentAddRequestDto), message);
            }

            _logger.LogInformation("The Student creating was started.");

            var student = _mapper.Map<Student>(studentAddRequestDto);

            var createdStudent = await _studentsRepository.CreateAsync(student);

            var response = _mapper.Map<StudentResponseDto>(createdStudent);

            _logger.LogInformation($"The Student with id {createdStudent.Id} was created successfully.");

            return response;
        }

        public async Task<bool> DeleteStudentById(Guid id)
        {
            _logger.LogInformation($"Deleting Student with Id = {id} was started.");

            Student? student = await _studentsRepository.GetByIdAsync(id);

            if (student is null)
            {
                _logger.LogInformation($"Student with Id = {id} wasn't found.");
                return false;
            }

            try
            {
                await _studentsRepository.DeleteByIdAsync(id);
                _logger.LogInformation($"The Student with Id = {id} was successfully deleted.");
            }
            catch (DBConcurrencyException)
            {
                _logger.LogError($"Deleting Student with Id = {id} was failed.");
                throw;
            }

            return true;
        }

        public async Task<List<StudentResponseDto>> GetAllStudents()
        {
            _logger.LogInformation("Getting all Students was started.");

            var students = await _studentsRepository.GetAllAsync();

            _logger.LogInformation(!students.Any()
            ? "The Student table is empty."
            : $"All {students.Count()} records were successfully received from the Student table");

            return students.Select(s => _mapper.Map<StudentResponseDto>(s)).ToList();
        }

        public async Task<StudentResponseDto> GetStudentById(Guid? id)
        {
            _logger.LogInformation($"Getting Student by Id was started. Looking Id = {id}.");

            if (id is null)
            {
                var message = "Student id can't be null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(id), message);
            }

            Student? student = await _studentsRepository.GetByIdAsync(id.Value);

            if (student is null)
            {
                var message = $"There is no object by such id: {id}";
                _logger.LogError(message);
                throw new KeyNotFoundException(message);
            }

            _logger.LogInformation($"Got a Student with Id = {id}.");

            return _mapper.Map<StudentResponseDto>(student);
        }

        public async Task<List<Student>> GetAllStudentsByIds(List<Guid> ids)
        {
            _logger.LogInformation($"Getting Students by their Ids was started.");

            if (ids is null)
            {
                var message = "Student ids collection can't be null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(ids), message);
            }

            List<Student> students = await _studentsRepository.GetAllByIdsAsync(ids);

            if (students is null)
            {
                var message = $"There are no objects by such ids";
                _logger.LogError(message);
                throw new KeyNotFoundException(message);
            }

            _logger.LogInformation($"Got Students with given ids.");

            return students;
        }

        public async Task<StudentResponseDto> UpdateStudent(StudentUpdateRequestDto? studentUpdateRequestDto)
        {
            if (studentUpdateRequestDto is null)
            {
                var message = "StudentUpdateRequestDto is null";
                _logger.LogError(message);
                throw new ArgumentNullException(nameof(studentUpdateRequestDto), message);
            }

            _logger.LogInformation($"Updating Student with Id = {studentUpdateRequestDto.Id} was started.");


            var student = _mapper.Map<Student>(studentUpdateRequestDto);

            await _studentsRepository.UpdateAsync(student);

            var result = _mapper.Map<StudentResponseDto>(student);

            _logger.LogInformation($"The student with Id = {studentUpdateRequestDto.Id} was updated.");

            return result;
        }
    }
}
