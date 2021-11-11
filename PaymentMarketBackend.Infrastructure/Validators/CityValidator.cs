using FluentValidation;
using Microsoft.Extensions.Primitives;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class CityValidator : AbstractValidator<CityDto>
    {
        public CityValidator()
        {
            RuleFor(city => city.City)
                .NotNull()
                .WithMessage("El campo 'City' no puede ser nulo");
                

            RuleFor(city => city.City)
                .Length(3, 50)
                .WithMessage("El campo 'City' debe tener entre 3 y 50 caracteres");

        }
    }
}