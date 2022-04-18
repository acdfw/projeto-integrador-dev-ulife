using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class AvaliacaoMatriculaRepository : BaseRepository<AvaliacaoMatricula>, IAvaliacaoMatriculaRepository
    {
        public AvaliacaoMatriculaRepository(IntegradorContext context) : base(context)
        {
        }

        public IList<AvaliacaoRealizadaTurmaResponse> ConsultarAvaliacoesTurmas()
        {
            var query = from avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                        join avaliacao in _context.Set<Avaliacao>()
                            on avaliacaoMatricula.AvaliacaoId equals avaliacao.Id
                        join turma in _context.Set<Turma>()
                            on avaliacao.TurmaId equals turma.Id
                        select new AvaliacaoRealizadaTurmaResponse
                        {
                            IdAvaliacao = avaliacao.Id.ToString(),
                            IdTurma = turma.Id.ToString()
                        };

            return query.ToList();
        }
    }
}
