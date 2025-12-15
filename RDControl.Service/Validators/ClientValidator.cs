using FluentValidation;
using RDControl.Domain.Entities;

namespace RDControl.Service.Validators
{
    public  class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator() 
        {
            RuleFor(m => m.Name)
                .NotEmpty().WithMessage("Client name is required.");
            RuleFor(m => m.CNPJ)
                .NotEmpty().WithMessage("Client CNPJ is required.")
                .MinimumLength(14).WithMessage("CNPJ must contain atleast 14 characters!")
                .MaximumLength(18).WithMessage("CNPJ must contain 18 characters maximum!");
        }
    }
}
