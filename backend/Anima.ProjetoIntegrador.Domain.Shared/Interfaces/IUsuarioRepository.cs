using Anima.ProjetoIntegrador.Domain.Entities;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario? ObterPorLoginSenha(string? login, string? senha);
    }
}
