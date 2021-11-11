using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class StateValidator : AbstractValidator<StateDto>
    {
        public StateValidator()
        {
            RuleFor(item => item.State)
                .NotNull()
                .WithMessage("El campo 'State' no puede ser nulo.");
            
            RuleFor(item => item.State)
                .Length(5, 50)
                .WithMessage("El campo 'State' debe contener entre 5 y 50 caracteres.");
        }
        
    }
}