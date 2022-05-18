using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class InvoiceValidator  : AbstractValidator<InvoiceDto>
    {
        public InvoiceValidator()
        {
            RuleFor(item => item.Valor)
                .NotNull()
                .GreaterThan(0)
                .WithMessage("El campo 'valor' tiene un error");

            RuleFor(item => item.Date)
                .NotNull()
                .WithMessage("El campo 'date' no puede ser nulo");
            
            RuleFor(item => item.IdChargeCard)
                .NotNull()
                .WithMessage("El campo 'IdChargeCard' no puede ser nulo");
            
            RuleFor(item => item.IdCobrador)
                .NotNull()
                .WithMessage("El campo 'IdCobrador' no puede ser nulo");

        }
    }
}