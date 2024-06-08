using AutoMapper;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.CourseDtos;

namespace TestTaskSoftServe.BLL.Mapping.CourseProfiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<CourseAddRequestDto, Course>()
                .ForMember(dest => dest.Students, source => source.MapFrom(c => c.StudentsIds))
                .ForMember(dest => dest.Teachers, source => source.MapFrom(c => c.TeachersIds));

            CreateMap<CourseUpdateRequestDto, Course>()
                .ForMember(dest => dest.Students, source => source.MapFrom(c => c.StudentsIds))
                .ForMember(dest => dest.Teachers, source => source.MapFrom(c => c.TeachersIds));

            CreateMap<Course, CourseResponseDto>()
                .ReverseMap();
        }
    }
}
