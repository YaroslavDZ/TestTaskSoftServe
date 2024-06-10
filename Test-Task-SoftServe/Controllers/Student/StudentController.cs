using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTaskSoftServe.BLL.Dto.StudentDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;

namespace Test_Task_SoftServe.Controllers.Student
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var studentResponseDtos =
                await _studentService.GetAllStudents().ConfigureAwait(false);

            if (!studentResponseDtos.Any())
            {
                return NoContent();
            }

            return Ok(studentResponseDtos);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid? id)
        {
            var studentResponseDto =
                await _studentService.GetStudentById(id).ConfigureAwait(false);

            return studentResponseDto is null ? NoContent() : Ok(studentResponseDto);
        }

        [Authorize("Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(StudentAddRequestDto? studentAddRequestDto)
        {
            if (studentAddRequestDto is null)
            {
                return BadRequest();
            }

            var studentResponseDto =
                await _studentService.CreateStudent(studentAddRequestDto).ConfigureAwait(false);

            return CreatedAtAction(nameof(GetById),
                new { studentResponseDto.Id },
                studentResponseDto);
        }

        [Authorize("Admin")]
        [HttpPut]
        public async Task<IActionResult> Update(StudentUpdateRequestDto? studentUpdateRequestDto)
        {
            var studentResponseDto =
                await _studentService.UpdateStudent(studentUpdateRequestDto).ConfigureAwait(false);

            return studentResponseDto is null ? NotFound() : Ok(studentResponseDto);
        }

        [Authorize("Admin")]
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            bool isDeleted = await _studentService.DeleteStudentById(id).ConfigureAwait(false);

            return isDeleted ? NoContent() : NotFound();
        }
    }
}
