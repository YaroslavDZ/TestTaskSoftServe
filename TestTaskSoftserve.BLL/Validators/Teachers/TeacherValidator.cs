using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;

namespace TestTaskSoftServe.BLL.Validators.Teachers
{
    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            const int MAXNAMELENGTH = 100;
            const int MAXSURNAMELENGTH = 100;
            const int MAXAGE = 150;
            const int MINAGE = 16;
            const int MAXEXPERIENCE = 100;
            const int MINEXPERIENCE = 0;

            RuleFor(t => t.Name)
                .NotEmpty()
                .WithMessage($"Name can't be blank")
                .MaximumLength(MAXNAMELENGTH)
                .WithMessage($"The length of name can't be greater than {MAXNAMELENGTH} characters");

            RuleFor(t => t.Surname)
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

            RuleFor(s => s.Experience)
                .NotEmpty()
                .WithMessage($"Experience can't be blank")
                .GreaterThan(MINEXPERIENCE)
                .WithMessage($"Experience can't be less than {MINEXPERIENCE}")
                .LessThan(MAXEXPERIENCE)
                .WithMessage($"Experience can't be greater than {MAXEXPERIENCE}");
        }
    }
}
