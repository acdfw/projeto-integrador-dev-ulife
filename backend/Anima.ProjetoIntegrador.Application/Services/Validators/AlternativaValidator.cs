using FluentValidation;
using FluentValidation.Results;
using Anima.ProjetoIntegrador.Domain.Requests;

namespace Anima.ProjetoIntegrador.Application.Services.Validators
{
    public class AlternativaValidator : AbstractValidator<NovaAlternativaRequest>
    {
        public AlternativaValidator()
        {
            RuleFor(alternativa => alternativa.Texto)
                .NotNull().NotEmpty()
                    .WithMessage("O campo texto da alternativa não pode ser vazio!");

            RuleFor(alternativa => alternativa.QuestaoId)
                .NotNull().NotEmpty()
                    .WithMessage("O id de questão não pode ser vazio!");

            RuleFor(alternativa => alternativa.AlternativaCorreta)
                .NotNull().Must(ac => ac == false || ac == true)
                    .WithMessage("Você deve indicar se esta alternativa é a correta ou não!");
        }
    }

    public static class AlternativaValidate
    {
        public static ValidationResult Validate(NovaAlternativaRequest alternativa, AlternativaValidator validator)
        {
            ValidationResult result = validator.Validate(alternativa);
            return result;
        }
    }
}
