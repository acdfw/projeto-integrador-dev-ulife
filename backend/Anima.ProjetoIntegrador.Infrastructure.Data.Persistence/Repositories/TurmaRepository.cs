using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        public TurmaRepository(IntegradorContext context) : base(context)
        {
        }

        public IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid id)
        {
            var query = from turma in _context.Set<Turma>()
                        join avaliacao in _context.Set<Avaliacao>()
                            on turma.Id equals avaliacao.TurmaId
                        join prova in _context.Set<Prova>()
                            on avaliacao.ProvaId equals prova.Id
                        where turma.Id == id
                        select new AvaliacaoTurmaResponse
                        {
                            IdAvaliacao = avaliacao.Id.ToString(),
                            NomeProva = prova.Nome
                        };

            return query.ToList();
        }

        public IList<AlunoMatriculaPorTurmaResponse> ConsultarAlunosMatriculadosPorTurma(Guid id)
        {
            var query = from turma in _context.Set<Turma>()
                        join matricula in _context.Set<Matricula>()
                            on turma.Id equals matricula.TurmaId
                        join aluno in _context.Set<Aluno>()
                            on matricula.AlunoId equals aluno.Id
                        join usuario in _context.Set<Usuario>()
                            on aluno.UsuarioId equals usuario.Id
                        where turma.Id == id
                        select new AlunoMatriculaPorTurmaResponse
                        {
                            Matricula = matricula.Id.ToString(),
                            NomeAluno = usuario.Nome
                        };

            return query.ToList();
        }

        public IList<TurmaResponse> ConsultarTurmas()
        {
            return GetQueryable().Select(q => new TurmaResponse
            {
                Id = q.Id.ToString(),
                NomeTurma = q.Nome
            }).ToList();
        }
    }
}
