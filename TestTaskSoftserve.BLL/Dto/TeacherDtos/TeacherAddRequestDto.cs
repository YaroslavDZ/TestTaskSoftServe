namespace TestTaskSoftServe.BLL.Dto.TeacherDtos
{
    public record TeacherAddRequestDto(
        string Name,
        string Surname,
        int Age,
        int Experience,
        List<Guid>? CourseIds);
}
