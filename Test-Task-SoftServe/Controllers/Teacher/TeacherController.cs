using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftServe.BLL.Dto.StudentDtos;
using TestTaskSoftServe.BLL.Dto.TeacherDtos;
using TestTaskSoftServe.BLL.Services.Interfaces;

namespace Test_Task_SoftServe.Controllers.Teacher
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var teacherResponseDtos = 
                await _teacherService.GetAllTeachers().ConfigureAwait(false);

            if (!teacherResponseDtos.Any())
            {
                return NoContent();
            }

            return Ok(teacherResponseDtos);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid? id)
        {
            var teacherResponseDto = 
                await _teacherService.GetTeacherById(id).ConfigureAwait(false);

            return teacherResponseDto is null ? NoContent() : Ok(teacherResponseDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TeacherAddRequestDto? teacherAddRequestDto)
        {
            if (teacherAddRequestDto is null)
            {
                return BadRequest();
            }

            var teacherResponseDto = 
                await _teacherService.CreateTeacher(teacherAddRequestDto).ConfigureAwait(false);

            return CreatedAtAction(nameof(GetById),
                new { teacherResponseDto.Id },
                teacherResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(TeacherUpdateRequestDto? teacherUpdateRequestDto)
        {
            var teacherResponseDto = 
                await _teacherService.UpdateTeacher(teacherUpdateRequestDto).ConfigureAwait(false);

            return teacherResponseDto is null ? NotFound() : Ok(teacherResponseDto);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            bool isDeleted = await _teacherService.DeleteTeacherById(id).ConfigureAwait(false);

            return isDeleted ? NoContent() : NotFound();
        }
    }
}
