using FluentValidation;
using FluentValidation.Results;
using Anima.ProjetoIntegrador.Domain.Requests;

namespace Anima.ProjetoIntegrador.Application.Services.Validators
{
    public class AvaliacaoValidator : AbstractValidator<NovaAvaliacaoRequest>
    {
        public AvaliacaoValidator()
        {
            RuleFor(avaliacao => avaliacao.ProvaId).NotNull().NotEmpty()
                .WithMessage("O id da prova não pode ser vazio");

            RuleFor(avaliacao => avaliacao.TurmaId).NotNull().NotEmpty()
                .WithMessage("O id da turma não pode ser vazio");

            RuleFor(avaliacao => avaliacao.NomeAvaliacao).NotNull().NotEmpty()
                .WithMessage("O Nome da avaliação não pode ser vazio");
        }
    }

    public static class AvaliacaoValidate
    {
        public static ValidationResult Validate(NovaAvaliacaoRequest avaliacao, AvaliacaoValidator validator)
        {
            ValidationResult result = validator.Validate(avaliacao);
            return result;
        }
    }
}
