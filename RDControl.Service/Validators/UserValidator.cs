using FluentValidation;
using RDControl.Domain.Entities;

namespace RDControl.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(m => m.Name)
                .NotEmpty().WithMessage("Name is required.");
            RuleFor(m => m.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
            RuleFor(m => m.Login)
                .NotEmpty().WithMessage("Login is required.");
            RuleFor(m => m.Password)
                .NotEmpty().WithMessage("Password is required!")
                .MinimumLength(8).WithMessage("Password must have atleast 8 character!")
                .MaximumLength(16).WithMessage("Password must have 16 character max!")
                .Matches(@"[A-Z]+").WithMessage("Password must contain an upper case letter!")
                .Matches(@"[a-z]+").WithMessage("Password must contain an lower case letter!")
                .Matches(@"[0-9]+").WithMessage("Password must contain a number!")
                .Matches(@".*[\W].*").WithMessage("Password must contain a special character (for example ! or ? or * or #)!");
            RuleFor(m => m.RegisterDate)
                .NotEmpty().WithMessage("Register Date is required.");
        }
    }
}
