using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class MarketValidator : AbstractValidator<MarketDto>
    {
        public MarketValidator()
        {
            RuleFor(item => item.Market)
                .NotNull()
                .WithMessage("El campo 'Market' no pude ser nulo.");
            
            RuleFor(item => item.Market)
                .Length(5, 50)
                .WithMessage("El campo 'Market' debe tener entre 5 y 50 caracteres.");
            
            RuleFor(item => item.IdNeighborhood)
                .NotNull()
                .WithMessage("El campo 'IdNeighborhood' no pude ser nulo.");
        }
    }
}