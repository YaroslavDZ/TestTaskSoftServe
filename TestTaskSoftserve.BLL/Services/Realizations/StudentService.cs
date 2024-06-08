using AutoMapper;
using System;
using System.Collections.Generic;
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

        public StudentService(IStudentsRepository studentsRepository, IMapper mapper)
        {
            _studentsRepository = studentsRepository;
            _mapper = mapper;
        }

        public async Task<StudentResponseDto> CreateStudent(StudentAddRequestDto? studentAddRequestDto)
        {
            if (studentAddRequestDto is null)
            {
                throw new ArgumentNullException(nameof(studentAddRequestDto), "Student dto is null");
            }

            var student = _mapper.Map<Student>(studentAddRequestDto);

            var createdStudent = await _studentsRepository.CreateAsync(student);

            var response = _mapper.Map<StudentResponseDto>(createdStudent);

            return response;
        }

        public async Task<bool> DeleteStudentById(Guid id)
        {
            Student? student = await _studentsRepository.GetByIdAsync(id);

            if (student is null)
            {
                return false;
            }

            await _studentsRepository.DeleteByIdAsync(id);

            return true;
        }

        public async Task<List<StudentResponseDto>> GetAllStudents()
        {
            var students = await _studentsRepository.GetAllAsync();

            return students.Select(s => _mapper.Map<StudentResponseDto>(s)).ToList();
        }

        public async Task<List<StudentResponseDto>> GetAllStudents(Expression<Func<Student, bool>> predicate)
        {
            var students = await _studentsRepository.GetAllAsync(predicate);

            return students.Select(s => _mapper.Map<StudentResponseDto>(s)).ToList();
        }

        public async Task<StudentResponseDto> GetStudentById(Guid? id)
        {
            if (id is null)
            {
                var message = "Id can't be null";
                throw new ArgumentNullException(nameof(id), message);
            }

            Student? student = await _studentsRepository.GetByIdAsync(id.Value);

            if (student is null)
            {
                var message = $"There is no object by such id: {id}";
                throw new KeyNotFoundException(message);
            }

            return _mapper.Map<StudentResponseDto>(student);
        }

        public async Task<StudentResponseDto> UpdateStudent(StudentUpdateRequestDto? studentUpdateRequestDto)
        {
            if (studentUpdateRequestDto is null)
            {
                var message = "Update dto is null";
                throw new ArgumentNullException(nameof(studentUpdateRequestDto), message);
            }

            var student = _mapper.Map<Student>(studentUpdateRequestDto);

            await _studentsRepository.UpdateAsync(student);

            return _mapper.Map<StudentResponseDto>(student);
        }
    }
}
