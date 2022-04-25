using FluentValidation;
using FluentValidation.Results;
using Anima.ProjetoIntegrador.Domain.Requests;

namespace Anima.ProjetoIntegrador.Application.Services.Validators
{
    public class TurmaValidator : AbstractValidator<NovaTurmaRequest>
    {
        public TurmaValidator()
        {
            RuleFor(turma => turma.Nome)
                .NotNull().NotEmpty().WithMessage("O nome do usuario não pode estar vazio!");

            RuleFor(turma => turma.UsuarioId)
                .NotNull().NotEmpty().WithMessage("O id do usuario não pode estar vazio!");
        }
    }
    public static class TurmaValidate
    {
        public static ValidationResult Validate(NovaTurmaRequest turma, TurmaValidator validator)
        {
            ValidationResult result = validator.Validate(turma);
            return result;
        }
    }

}
