using FluentValidation;
using PaymentMarketBackend.Core.DTOs;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class CountryValidator : AbstractValidator<CountryDto>
    {
        public CountryValidator()
        {
            RuleFor(item => item.Country)
                .NotNull()
                .WithMessage("El campo 'Country' no puede ser nulo.");

            RuleFor(item => item.Country)
                .Length(3, 50)
                .WithMessage("El campo 'Country' debe tener entre 3 y 50 caracteres.");
        }
    }
}