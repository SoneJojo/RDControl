using FluentValidation;
using RDControl.Domain.Entities;

namespace RDControl.Service.Validators
{
    public class TechnicianValidator : AbstractValidator<Technician>
    {
        public TechnicianValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty().WithMessage("Technician name is required.");
            RuleFor(m => m.CPF)
                .NotEmpty().WithMessage("Technician CPF is required.")
                .MinimumLength(11).WithMessage("CPF must contain atleast 11 characters!")
                .MaximumLength(14).WithMessage("CPF must contain 14 characters maximum!"); ;
            RuleFor(m => m.TechType)
                .IsInEnum().WithMessage("Technician type is invalid.");
        }
    }
}
