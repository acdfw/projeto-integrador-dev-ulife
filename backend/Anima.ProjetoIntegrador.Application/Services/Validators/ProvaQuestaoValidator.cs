using FluentValidation;
using FluentValidation.Results;
using Anima.ProjetoIntegrador.Domain.Requests;

namespace Anima.ProjetoIntegrador.Application.Services.Validators
{
    public class ProvaQuestaoValidator : AbstractValidator<NovaProvaQuestaoRequest>
    {
        public ProvaQuestaoValidator()
        {
            RuleFor(login => login.ProvaId)
                .NotNull().NotEmpty().WithMessage("O id da prova não pode estar vazio!");

            RuleFor(login => login.QuestaoId)
                .NotNull().NotEmpty().WithMessage("O id da questão não pode estar vazio!");
        }
    }

    public static class ProvaQuestaoValidate
    {
        public static ValidationResult Validate(NovaProvaQuestaoRequest provaQuestao,ProvaQuestaoValidator validator)
        {
            ValidationResult result = validator.Validate(provaQuestao);
            return result;
        }
    }
}
