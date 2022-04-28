
using FluentValidation;
using FluentValidation.Results;
using Anima.ProjetoIntegrador.Domain.Requests;

namespace Anima.ProjetoIntegrador.Application.Services.Validators
{
    public class ProvaValidator : AbstractValidator<NovaProvaRequest>
    {
        public ProvaValidator()
        {
            RuleFor(prova => prova.Nome)
                .NotNull().NotEmpty().WithMessage("O nome da prova não pode ser vazio");

            RuleFor(prova => prova.UsuarioId)
                .NotNull().NotEmpty().WithMessage("O id do professor não pode ser vazio");
        }
    }

    public static class ProvaValidate
    {
        public static ValidationResult Validate(NovaProvaRequest prova, ProvaValidator validator)
        {
            ValidationResult result = validator.Validate(prova);
            return result;
        }

    }
}
