using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class RolValidator : AbstractValidator<RolDto>
    {
        public RolValidator()
        {
            RuleFor(item => item.RolName)
                .NotNull()
                .WithMessage("El campo 'RolName' no puede ser nulo");
        }
    }
}