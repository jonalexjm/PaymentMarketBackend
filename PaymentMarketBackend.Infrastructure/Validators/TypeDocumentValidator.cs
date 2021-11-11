using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class TypeDocumentValidator : AbstractValidator<TypeDocumentDto>
    {
        public TypeDocumentValidator()
        {
            RuleFor(item => item.TypeDocument)
                .NotNull()
                .WithMessage("El campo 'TypeDocument' no puede ser nulo.");
            
            RuleFor(item => item.TypeDocument)
                .Length(5, 25)
                .WithMessage("El campo 'TypeDocument' debe contener entre 5 y 25 caracteres.");
        }
    }
}