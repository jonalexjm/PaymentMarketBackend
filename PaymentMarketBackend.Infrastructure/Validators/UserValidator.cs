using FluentValidation;
using PaymentMarketBackend.Core.DTOs;

namespace PaymentMarketBackend.Infrastructure.Validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(item => item.Name)
                .NotNull()
                .WithMessage("El campo 'Name' no puede ser nulo.");
            
            RuleFor(item => item.Name)
                .Length(5, 25)
                .WithMessage("El campo 'Name' debe contener entre 5 y 25 caracteres.");
            
            RuleFor(item => item.Lastname)
                .NotNull()
                .WithMessage("El campo 'Lastname' no puede ser nulo.");
            
            RuleFor(item => item.Lastname)
                .Length(5, 25)
                .WithMessage("El campo 'Lastname' debe contener entre 5 y 25 caracteres.");
            
            RuleFor(item => item.Address)
                .NotNull()
                .WithMessage("El campo 'Address' no puede ser nulo.");
            
            RuleFor(item => item.Address)
                .Length(5, 25)
                .WithMessage("El campo 'Address' debe contener entre 5 y 25 caracteres.");
            
            RuleFor(item => item.Phone)
                .NotNull()
                .WithMessage("El campo 'Phone' no puede ser nulo.");
            
            RuleFor(item => item.Phone)
                .Length(5, 25)
                .WithMessage("El campo 'Phone' debe contener entre 5 y 25 caracteres.");
            
            RuleFor(item => item.NumberDocument)
                .NotNull()
                .WithMessage("El campo 'NumberDocument' no puede ser nulo.");
            
            RuleFor(item => item.NumberDocument)
                .Length(5, 50)
                .WithMessage("El campo 'NumberDocument' debe contener entre 5 y 25 caracteres.");
            
            RuleFor(item => item.IdCity)
                .NotNull()
                .WithMessage("El campo 'IdCity' no puede ser nulo.");
            
            RuleFor(item => item.IdTypeDocument)
                .NotNull()
                .WithMessage("El campo 'IdTypeDocument' no puede ser nulo.");

        }
    }
}