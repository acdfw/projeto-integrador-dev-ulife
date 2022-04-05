using Anima.ProjetoIntegrador.Domain.Entities;

namespace Anima.ProjetoIntegrador.Infrastructure.Auth.TokenGenerator
{
    public interface ITokenService
    {
        string GenerateToken(Usuario usuario);
    }
}
