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
                .NotEmpty().WithMessage("Technician CPF is required.");
            RuleFor(m => m.TechType)
                .IsInEnum().WithMessage("Technician type is invalid.");
        }
    }
}
