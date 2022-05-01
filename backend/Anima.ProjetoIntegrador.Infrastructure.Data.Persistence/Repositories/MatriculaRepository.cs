using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class MatriculaRepository : BaseRepository<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository(IntegradorContext context) : base(context)
        {
        }

        public Guid ObterPorAluno(Guid usuarioId)
        {
            var query = from matricula in _context.Set<Matricula>()
                        join aluno in _context.Set<Aluno>()
                            on matricula.AlunoId equals aluno.Id
                        join usuario in _context.Set<Usuario>()
                            on aluno.UsuarioId equals usuario.Id
                        where usuario.Id == usuarioId
                        select matricula.Id;

            return query.FirstOrDefault();
        }
    }
}
