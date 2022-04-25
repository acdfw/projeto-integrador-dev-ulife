using FluentValidation;
using FluentValidation.Results;
using Anima.ProjetoIntegrador.Domain.Requests;


namespace Anima.ProjetoIntegrador.Application.Services.Validators
{
    public class QuestaoValidator : AbstractValidator<NovaQuestaoRequest>
    {
        public QuestaoValidator()
        {
            RuleFor(questao => questao.Enunciado)
                .NotNull().NotEmpty().WithMessage("O enunciado não pode estar vazio!");

            RuleFor(questao => questao.UsuarioId)
                .NotNull().NotEmpty().WithMessage("O id do professor não pode estar vazio!");
        }
    }
    public static class QuestaoValidate
    {
        public static ValidationResult Validate(NovaQuestaoRequest questao, QuestaoValidator validator)
        {
            ValidationResult result = validator.Validate(questao);
            return result;
        }
    }
}
