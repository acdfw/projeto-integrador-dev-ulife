using Anima.ProjetoIntegrador.Application.Responses;
using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(IntegradorContext context) : base(context)
        {
        }
        
        public IList<TurmaInscritoProfessorResponse> ConsultarTurmasQuantidadeInscritos(Guid id)
        {
            var query = from professor in _context.Set<Professor>()
                        join turma in _context.Set<Turma>()
                            on professor.Id equals turma.ProfessorId
                        where professor.Id == id
                        select new TurmaInscritoProfessorResponse
                        {
                            IdTurma = turma.Id.ToString(),
                            NomeTurma = turma.Nome
                            // TODO: QtdInscritos - não sei no momento como integrar isto nesta query
                        };

            return query.ToList();
        }             

        public IList<AvaliacaoDisponivelTurmaProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id)
        {
            var query = from professor in _context.Set<Professor>()
                        join turma in _context.Set<Turma>()
                            on professor.Id equals turma.ProfessorId
                        join avaliacao in _context.Set<Avaliacao>()
                            on turma.Id equals avaliacao.TurmaId
                        join prova in _context.Set<Prova>()
                            on avaliacao.ProvaId equals prova.Id
                        where professor.Id == id
                        select new AvaliacaoDisponivelTurmaProfessorResponse
                        {
                            NomeTurma = turma.Nome,
                            NomeProva = prova.Nome,
                            ModeloProva = prova.Id.ToString()
                        };

            return query.ToList();
        }               
    }
}
