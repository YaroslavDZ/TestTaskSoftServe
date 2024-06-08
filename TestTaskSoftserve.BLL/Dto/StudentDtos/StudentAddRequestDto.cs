namespace TestTaskSoftServe.BLL.Dto.StudentDtos
{
    public record StudentAddRequestDto(
        string Name,
        string Surname,
        int Age, 
        int StudyYear,
        string Group,
        List<Guid>? CoursesIds);
}
