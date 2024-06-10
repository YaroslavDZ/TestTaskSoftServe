using FluentValidation;
using TestTaskSoftserve.DAL.Entities;

namespace TestTaskSoftServe.BLL.Validators.Students
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator() 
        {
            const int MAXNAMELENGTH = 100;
            const int MAXSURNAMELENGTH = 100;
            const int MAXAGE = 150;
            const int MINAGE = 1;
            const int MINSTUDYYEAR = 1;
            const int MAXSTUDYYEAR = 100;
            const int MAXGROUPLENGTH = 30;

            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage($"Name can't be blank")
                .MaximumLength(MAXNAMELENGTH)
                .WithMessage($"The length of name can't be greater than {MAXNAMELENGTH} characters");

            RuleFor(s => s.Surname)
                .NotEmpty()
                .WithMessage($"Surname can't be blank")
                .MaximumLength(MAXSURNAMELENGTH)
                .WithMessage($"The length of surname can't be greater than {MAXSURNAMELENGTH} characters");

            RuleFor(s => s.Age)
                .NotEmpty()
                .WithMessage($"Age can't be blank")
                .GreaterThan(MINAGE)
                .WithMessage($"Age can't be less than {MINAGE}")
                .LessThan(MAXAGE)
                .WithMessage($"Age can't be greater than {MAXAGE}");

            RuleFor(s => s.StudyYear)
                .NotEmpty()
                .WithMessage($"StudyYear can't be blank")
                .GreaterThan(MINAGE)
                .WithMessage($"StudyYear can't be less than {MINSTUDYYEAR}")
                .LessThan(MAXSTUDYYEAR)
                .WithMessage($"StudyYear can't be greater than {MAXSTUDYYEAR}");

            RuleFor(s => s.Group)
                .NotEmpty()
                .WithMessage($"Group can't be blank")
                .MaximumLength(MAXGROUPLENGTH)
                .WithMessage($"The length of group can't be greater than {MAXGROUPLENGTH} characters");
        }
    }
}
