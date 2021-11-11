using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class ChargeCardValidator : AbstractValidator<ChargeCardDto>
    {
        public ChargeCardValidator()
        {
            RuleFor(chargeCard => chargeCard.Description)
                .NotNull()
                .WithMessage("El campo 'description' no puede ser nulo");

            RuleFor(chargeCard => chargeCard.Valor)
                .NotNull()
                .WithMessage("El campo 'valor no puede ser nulo'");
            
            RuleFor(chargeCard => chargeCard.Valor)
                .GreaterThan(0)
                .WithMessage("El campo 'valor' debe ser mayor a 0");

            RuleFor(chargeCard => chargeCard.IdCustomer)
                .NotNull()
                .WithMessage("El campo 'IdCustomer' no puede ser nulo");

            RuleFor(chargeCard => chargeCard.IdMarket)
                .NotNull()
                .WithMessage("El campo 'IdMarket' no puede ser nulo");

            RuleFor(chargeCard => chargeCard.IdAnnio)
                .NotNull()
                .WithMessage("El campo 'IdAnnio' no puede ser nulo");

        }
    }
}