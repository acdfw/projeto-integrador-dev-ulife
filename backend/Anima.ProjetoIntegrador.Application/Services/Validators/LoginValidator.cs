using FluentValidation;
using FluentValidation.Results;
using Anima.ProjetoIntegrador.Domain.Requests;

namespace Anima.ProjetoIntegrador.Application.Services.Validators
{
    public class LoginValidator : AbstractValidator<LoginUsuarioRequest>
    {
        public LoginValidator()
        {
            RuleFor(login => login.Login)
                .NotNull().NotEmpty().WithMessage("O login não pode ser vazio");

            RuleFor(login => login.Senha)
                .NotNull().NotEmpty().WithMessage("A senha não pode estar vazia");
        }
    }

    public static class LoginValidate
    {
        public static ValidationResult Validate(LoginUsuarioRequest login, LoginValidator validator)
        {
            ValidationResult result = validator.Validate(login);
            return result;
        }
    }
}
