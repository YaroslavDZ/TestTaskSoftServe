using AutoMapper;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.StudentDtos;

namespace TestTaskSoftServe.BLL.Mapping.StudentProfiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentAddRequestDto, Student>();
            CreateMap<StudentUpdateRequestDto, Student>();
            CreateMap<Student, StudentResponseDto>().ReverseMap();
        }
    }
}
