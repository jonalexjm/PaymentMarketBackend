using FluentValidation;
using PaymentMarketBackend.Core.DTOs;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class AnnioValidator : AbstractValidator<AnnioDto>
    {
        public AnnioValidator()
        {
            RuleFor(post => post.Annio)
                .NotNull()
                .GreaterThan(2015)
                .WithMessage("El campo 'annio' no pude ser nulo");
            RuleFor(post => post.Annio)
                .GreaterThan(2015)
                .WithMessage("El campo 'annio' debe ser mayor a 2015");

        }
        
    }
}