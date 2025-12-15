using FluentValidation;
using RDControl.Domain.Entities;

namespace RDControl.Service.Validators
{
    public class EquipmentValidator : AbstractValidator<Equipment>
    {
        public EquipmentValidator() 
        { 
            RuleFor(m => m.Serial)
                .NotEmpty().WithMessage("Equipment serial is required (No Serial Number put 0 instead)");
            RuleFor(m => m.Model)
                .NotEmpty().WithMessage("Equipment model is required");
            RuleFor(m => m._Place)
                .NotNull().WithMessage("Equipment place is required");
        }
    }
}
