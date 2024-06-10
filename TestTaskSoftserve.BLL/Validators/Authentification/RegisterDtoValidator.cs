using FluentValidation;
using TestTaskSoftServe.BLL.Dto.AuthentificationDtos;

namespace TestTaskSoftServe.BLL.Validators.Authentification
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator() 
        {
            RuleFor(r => r.PersonName)
                .NotEmpty()
                .WithMessage("PersonName can't be blank.");

            RuleFor(r => r.Email)
                .NotEmpty()
                .WithMessage("Email can't be blank.")
                .EmailAddress()
                .WithMessage("Email is not in a proper format.");

            RuleFor(r => r.Password)
                .NotEmpty()
                .WithMessage("Password can't be blank.")
                .MinimumLength(4)
                .WithMessage("The minimal length of the password should be 4.")
                .Equal(r => r.ConfirmPassword)
                .WithMessage("ConfirmPassword and Password do not match.");

            RuleFor(r => r.ConfirmPassword)
                .NotEmpty()
                .WithMessage("ConfirmPassword can't be blank.")
                .Equal(r => r.Password)
                .WithMessage("ConfirmPassword and Password do not match.");
        }
    }
}
