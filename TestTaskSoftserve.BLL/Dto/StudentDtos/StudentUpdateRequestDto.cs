namespace TestTaskSoftServe.BLL.Dto.StudentDtos
{
    public record StudentUpdateRequestDto(
        Guid Id,
        string Name,
        string Surname,
        int Age,
        int StudyYear,
        string Group,
        List<Guid>? CoursesIds);
}
