using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTaskSoftServe.BLL.Dto.CourseDtos;
using TestTaskSoftServe.BLL.Dto.TeacherDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.BLL.Services.Realizations;

namespace Test_Task_SoftServe.Controllers.Course
{
    [ApiController]
    [Route("api/[controller]/[action]")]
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
            var courseResponseDtos =
                await _courseService.GetAllCourses().ConfigureAwait(false);

            if (!courseResponseDtos.Any())
            {
                return NoContent();
            }

            return Ok(courseResponseDtos);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid? id)
        {
            var courseResponseDto =
                await _courseService.GetCourseById(id).ConfigureAwait(false);

            return courseResponseDto is null ? NoContent() : Ok(courseResponseDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseAddRequestDto? courseAddRequestDto)
        {
            if (courseAddRequestDto is null)
            {
                return BadRequest();
            }

            var courseResponseDto =
                await _courseService.CreateCourse(courseAddRequestDto).ConfigureAwait(false);

            return CreatedAtAction(nameof(GetById),
                new { courseResponseDto.Id },
                courseResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateRequestDto? courseUpdateRequestDto)
        {
            var courseResponseDto =
                await _courseService.UpdateCourse(courseUpdateRequestDto).ConfigureAwait(false);

            return courseResponseDto is null ? NotFound() : Ok(courseResponseDto);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            bool isDeleted = await _courseService.DeleteCourseById(id).ConfigureAwait(false);

            return isDeleted ? NoContent() : NotFound();
        }
    }
}
