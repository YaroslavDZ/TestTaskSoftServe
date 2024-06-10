using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;

namespace TestTaskSoftServe.BLL.Validators.Courses
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator() 
        {
            const int MAXTITLELENGTH = 100;
            const int MAXDESCRIPTIONLENGTH = 500;

            RuleFor(c => c.Title)
                .NotEmpty()
                .WithMessage("Title can't be blank")
                .MaximumLength(MAXTITLELENGTH)
                .WithMessage($"Length of title can't more than {MAXTITLELENGTH} characters");

            RuleFor(c => c.Description)
                .MaximumLength(MAXDESCRIPTIONLENGTH)
                .WithMessage($"Length of description can't more than {MAXDESCRIPTIONLENGTH} characters");
        }
    }
}
