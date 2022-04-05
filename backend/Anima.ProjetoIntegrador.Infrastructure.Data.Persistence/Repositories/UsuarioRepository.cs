using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IntegradorContext context) : base(context)
        {
        }

        public Usuario? ObterPorLoginSenha(string? login, string? senha)
        {
            return _context.Set<Usuario>().FirstOrDefault(u => u.Login == login && u.Senha == senha);
        }
    }
}
