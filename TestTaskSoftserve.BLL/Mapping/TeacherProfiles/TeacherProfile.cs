using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.TeacherDtos;

namespace TestTaskSoftServe.BLL.Mapping.TeacherProfiles
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<TeacherAddRequestDto, Teacher>();
            CreateMap<TeacherUpdateRequestDto, Teacher>();
            CreateMap<Teacher, TeacherResponseDto>().ReverseMap();
        }
    }
}
