using FluentValidation;
using RDControl.Domain.Entities;

namespace RDControl.Service.Validators
{
    public class PlaceValidator : AbstractValidator<Place>
    {
        public PlaceValidator()
        {
            RuleFor(m => m.Pname)
                .NotEmpty().WithMessage("Place name is required.");
            RuleFor(m => m.Address)
                .NotEmpty().WithMessage("Place address is required.");
            RuleFor(m => m._Client)
                .NotEmpty().WithMessage("Client is required.");
        }
    }
}
