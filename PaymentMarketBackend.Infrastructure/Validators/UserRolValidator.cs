using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class UserRolValidator : AbstractValidator<UserRolDto>
    {
        public UserRolValidator()
        {
            RuleFor(item => item.IdUser)
                .NotNull()
                .WithMessage("El campo 'IdUser' no puede ser nulo.");
            
            RuleFor(item => item.IdRol)
                .NotNull()
                .WithMessage("El campo 'IdRol' no puede ser nulo.");
        }
        
    }
}