using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftServe.BLL.Dto.AuthentificationDtos;

namespace TestTaskSoftServe.BLL.Validators.Authentification
{
    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(l => l.Email)
                .NotEmpty()
                .WithMessage("Email can't be blank.")
                .EmailAddress()
                .WithMessage("Email is not in a proper format.");

            RuleFor(l => l.Password)
                .NotEmpty()
                .WithMessage("Password can't be blank.");
        }
    }
}
