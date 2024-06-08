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
using TestTaskSoftServe.BLL.Dto.TeacherDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Students;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Teachers;
using TestTaskSoftServe.DAL.Repositories.Realizations.Students;

namespace TestTaskSoftServe.BLL.Services.Realizations
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeachersRepository _teachersRepository;
        private readonly IMapper _mapper;

        public TeacherService(ITeachersRepository teachersRepository, IMapper mapper)
        {
            _teachersRepository = teachersRepository;
            _mapper = mapper;
        }
        public async Task<TeacherResponseDto> CreateTeacher(TeacherAddRequestDto? teacherAddRequestDto)
        {
            if (teacherAddRequestDto is null)
            {
                var message = "Teacher dto is null";
                throw new ArgumentNullException(nameof(teacherAddRequestDto), message);
            }

            var teacher = _mapper.Map<Teacher>(teacherAddRequestDto);

            var createdTeacher = await _teachersRepository.CreateAsync(teacher);

            var response = _mapper.Map<TeacherResponseDto>(createdTeacher);

            return response;
        }

        public async Task<bool> DeleteTeacherById(Guid id)
        {
            Teacher? teacher = await _teachersRepository.GetByIdAsync(id);

            if (teacher is null)
            {
                return false;
            }

            await _teachersRepository.DeleteByIdAsync(id);

            return true;
        }

        public async Task<List<TeacherResponseDto>> GetAllTeachers()
        {
            var teachers = await _teachersRepository.GetAllAsync();

            return teachers.Select(t => _mapper.Map<TeacherResponseDto>(t)).ToList();
        }

        public async Task<List<TeacherResponseDto>> GetAllTeachers(Expression<Func<Teacher, bool>> predicate)
        {
            var teachers = await _teachersRepository.GetAllAsync(predicate);

            return teachers.Select(t => _mapper.Map<TeacherResponseDto>(t)).ToList();
        }

        public async Task<TeacherResponseDto> GetTeacherById(Guid? id)
        {
            if (id is null)
            {
                var message = "Id can't be null";
                throw new ArgumentNullException(nameof(id), message);
            }

            Teacher? teacher = await _teachersRepository.GetByIdAsync(id.Value);

            if (teacher is null)
            {
                var message = $"There is no object by such id: {id}";
                throw new KeyNotFoundException(message);
            }

            return _mapper.Map<TeacherResponseDto>(teacher);
        }

        public async Task<TeacherResponseDto> UpdateTeacher(TeacherUpdateRequestDto? teacherUpdateRequestDto)
        {
            if (teacherUpdateRequestDto is null)
            {
                var message = "Update dto is null";
                throw new ArgumentNullException(nameof(teacherUpdateRequestDto), message);
            }

            var teacher = _mapper.Map<Teacher>(teacherUpdateRequestDto);

            await _teachersRepository.UpdateAsync(teacher);

            return _mapper.Map<TeacherResponseDto>(teacher);
        }
    }
}
