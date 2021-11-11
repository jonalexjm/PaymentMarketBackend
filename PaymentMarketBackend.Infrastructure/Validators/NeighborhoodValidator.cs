using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class NeighborhoodValidator : AbstractValidator<NeighborhoodDto>
    {
        public NeighborhoodValidator()
        {
            RuleFor(item => item.Neighborhood)
                .NotNull()
                .WithMessage("El campo 'Neighborhood' no pude ser nulo.");
            
            RuleFor(item => item.Neighborhood)
                .Length(5, 50)
                .WithMessage("El campo 'Neighborhood' debe contener entre 5 y 50 caracteres.");
            
            RuleFor(item => item.IdCity)
                .NotNull()
                .WithMessage("El campo 'IdCity' no pude ser nulo.");
        }
    }
}