using AutoMapper;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.CourseDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;

namespace TestTaskSoftServe.BLL.Mapping.CourseProfiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<CourseAddRequestDto, Course>().ReverseMap();

            CreateMap<CourseUpdateRequestDto, Course>().ReverseMap();

            CreateMap<Course, CourseResponseDto>()
                .ReverseMap();
        }
    }
}
