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
                            NomeTurma = turma.Nome
                            // TODO: QtdInscritos - não sei no momento como integrar isto nesta query
                        };

            return query.ToList();
        }

        public IList<AvaliacaoInscritoProfessorResponse> ConsultarAvaliacoesInscritosPorTurma(Guid id, Guid idTurma)
        {
            var query = from professor in _context.Set<Professor>()
                        join turma in _context.Set<Turma>()
                            on professor.Id equals turma.ProfessorId
                        join prova in _context.Set<Prova>()
                            on professor.Id equals prova.ProfessorId
                        join avaliacao in _context.Set<Avaliacao>()
                            on prova.Id equals avaliacao.ProvaId
                        join avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                            on avaliacao.Id equals avaliacaoMatricula.AvaliacaoId
                        join matricula in _context.Set<Matricula>()
                            on avaliacaoMatricula.MatriculaId equals matricula.Id
                        join aluno in _context.Set<Aluno>()
                            on matricula.AlunoId equals aluno.Id
                        join usuario in _context.Set<Usuario>()
                            on aluno.UsuarioId equals usuario.Id
                        where professor.Id == id && turma.Id == idTurma
                        select new AvaliacaoInscritoProfessorResponse
                        {
                            NomeProva = prova.Nome,
                            NomeAluno = usuario.Nome
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
                            ModeloProva = prova.Id
                        };

            return query.ToList();
        }
    }
}
