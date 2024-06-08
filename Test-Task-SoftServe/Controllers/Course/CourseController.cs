using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTaskSoftServe.BLL.Dto.CourseDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;

namespace Test_Task_SoftServe.Controllers.Course
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            List<CourseResponseDto> courseResponseDtos = await _courseService.GetAllCourses();

            return Ok(courseResponseDtos);
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid? id)
        {
            CourseResponseDto courseResponseDto = await _courseService.GetCourseById(id);

            return Ok(courseResponseDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseAddRequestDto? courseAddRequestDto)
        {
            CourseResponseDto courseResponseDto = await _courseService.CreateCourse(courseAddRequestDto);

            return Ok(courseResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateRequestDto? courseUpdateRequestDto)
        {
            var courseResponseDto = await _courseService.UpdateCourse(courseUpdateRequestDto);

            if (courseResponseDto is null) 
            {
                return NotFound();
            }

            return Ok(courseResponseDto);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            bool isDeleted = await _courseService.DeleteCourseById(id);

            return isDeleted ? NoContent() : NotFound();
        }
    }
}
