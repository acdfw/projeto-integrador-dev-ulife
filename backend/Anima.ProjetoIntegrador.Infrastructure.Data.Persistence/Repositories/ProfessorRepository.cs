using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(IntegradorContext context) : base(context)
        {
        }
        
        public IList<TurmaResponse> ConsultarTurmas(Guid id)
        {
            var query = from professor in _context.Set<Professor>()
                        join turma in _context.Set<Turma>()
                            on professor.Id equals turma.ProfessorId
                        where professor.Id == id
                        select new TurmaResponse
                        {
                            Id = turma.Id.ToString(),
                            NomeTurma = turma.Nome                            
                        };

            return query.ToList();
        }      
        
        public IList<TurmaAlunoMatriculaResponse> ConsultarInscritosDasSuasTurmas(Guid id)
        {
            var query = from professor in _context.Set<Professor>()
                        join turma in _context.Set<Turma>()
                            on professor.Id equals turma.ProfessorId
                        join matricula in _context.Set<Matricula>()
                            on turma.Id equals matricula.TurmaId
                        join aluno in _context.Set<Aluno>()
                            on matricula.AlunoId equals aluno.Id
                        join usuario in _context.Set<Usuario>()
                            on aluno.UsuarioId equals usuario.Id
                        where professor.Id == id
                        select new TurmaAlunoMatriculaResponse
                        {
                            IdTurma = turma.Id.ToString(),
                            NomeTurma = turma.Nome,
                            NomeAluno = usuario.Nome,
                            Matricula = matricula.Id.ToString()
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
                            IdTurma = turma.Id.ToString(),
                            NomeTurma = turma.Nome,
                            NomeProva = prova.Nome,
                            ModeloProva = prova.Id.ToString()
                        };

            return query.ToList();
        }
    }
}
