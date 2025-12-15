using FluentValidation;
using RDControl.Domain.Entities;

namespace RDControl.Service.Validators
{
    public class ReportValidator : AbstractValidator<Report>
    {
        public ReportValidator()
        {
            RuleFor(m => m.Description)
                .NotEmpty().WithMessage("Report description is required.");
            RuleFor(m => m._Technician)
                .NotEmpty().WithMessage("Technician is required.");
            RuleFor(m => m.Equip)
                .NotEmpty().WithMessage("Equipment is required.");
            RuleFor(m => m.Hours)
                .NotEmpty().WithMessage("Hours worked is required.")
                .GreaterThanOrEqualTo(0).WithMessage("Hours worked must be atleast zero.");
            RuleFor(m => m.Hours_price)
                .NotEmpty().WithMessage("Hourly rate is required.")
                .GreaterThanOrEqualTo(0).WithMessage("Hourly rate must be atleast zero.");
            RuleFor(m => m.Observation)
                .NotEmpty().WithMessage("Report observation is required.");
            RuleFor(m => m.Ticket)
                .NotEmpty().WithMessage("Ticket reason is required.");
            RuleFor(m => m.Situation)
                .IsInEnum().WithMessage("Situation type is invalid.");
            RuleFor(m => m.Payment)
                .IsInEnum().WithMessage("Payment type is invalid.");
            RuleFor(m => m.Date)
                .NotEmpty().WithMessage("Report date is required.");
            RuleFor(m => m._User)
                .NotEmpty().WithMessage("User is required.");
        }
    }
}
