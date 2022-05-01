using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class AvaliacaoRepository : BaseRepository<Avaliacao>, IAvaliacaoRepository
    {
        public AvaliacaoRepository(IntegradorContext context) : base(context)
        {
        }

        public AvaliacaoProvaResponse? ObterProvaTurmaPorAvaliacao(Guid id)
        {
            var query = from avaliacao in _context.Set<Avaliacao>()
                        join turma in _context.Set<Turma>()
                            on avaliacao.TurmaId equals turma.Id
                        join professor in _context.Set<Professor>()
                            on turma.ProfessorId equals professor.Id
                        join usuario in _context.Set<Usuario>()
                            on professor.UsuarioId equals usuario.Id
                        join prova in _context.Set<Prova>()
                            on avaliacao.ProvaId equals prova.Id
                        where avaliacao.Id == id
                        select new AvaliacaoProvaResponse
                        {
                            ProvaId = prova.Id.ToString(),
                            NomeProva = prova.Nome,
                            NomeAvaliacao = avaliacao.Nome,
                            NomeTurma = turma.Nome,
                            NomeProfessor = usuario.Nome
                        };

            return query.FirstOrDefault();
        }

        public IList<AlunoMatriculadoTurmaResponse> ConsultarTurmaInscritosPorAvaliacao(Guid id)
        {
            var query = from avaliacao in _context.Set<Avaliacao>()
                        join turma in _context.Set<Turma>()
                            on avaliacao.TurmaId equals turma.Id
                        join matricula in _context.Set<Matricula>()
                            on turma.Id equals matricula.TurmaId
                        join avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                            on matricula.Id equals avaliacaoMatricula.MatriculaId
                        into avaliacaoMatriculaLeft
                        from avaliacaoMatriculaLefted in avaliacaoMatriculaLeft.DefaultIfEmpty()                        
                        join aluno in _context.Set<Aluno>()
                            on matricula.AlunoId equals aluno.Id
                        join usuario in _context.Set<Usuario>()
                            on aluno.UsuarioId equals usuario.Id
                        where avaliacao.Id == id
                        select new AlunoMatriculadoTurmaResponse
                        {
                            AvaliacaoId = avaliacao.Id.ToString(),
                            Matricula = matricula.Id.ToString(),
                            NomeAluno = usuario.Nome,
                            Nota = avaliacaoMatriculaLefted.Nota
                        };

            return query.ToList();
        }

        public Guid Criar(Avaliacao avaliacao)
        {
            return Add(avaliacao).Id;
        }

        public TurmaProfessorAlunoResponse ObterProfessorAlunoTurmaDaAvaliacao(Guid id)
        {
            var query = from avaliacao in _context.Set<Avaliacao>()
                        join turma in _context.Set<Turma>()
                            on avaliacao.TurmaId equals turma.Id
                        join matricula in _context.Set<Matricula>()
                            on turma.Id equals matricula.TurmaId
                        join aluno in _context.Set<Aluno>()
                            on matricula.AlunoId equals aluno.Id
                        join usuarioAluno in _context.Set<Usuario>()
                            on aluno.UsuarioId equals usuarioAluno.Id
                        join professor in _context.Set<Professor>()
                            on turma.ProfessorId equals professor.Id
                        join usuarioProfessor in _context.Set<Usuario>()
                            on professor.UsuarioId equals usuarioProfessor.Id
                        where avaliacao.Id == id
                        select new TurmaProfessorAlunoResponse
                        {
                            NomeTurma = turma.Nome,
                            NomeProfessor = usuarioProfessor.Nome,
                            NomeAluno = usuarioAluno.Nome
                        };

            return query.SingleOrDefault();
        }

        public Avaliacao? ObterPorId(Guid avaliacaoId)
        {
            return _context.Set<Avaliacao>().FirstOrDefault(a => a.Id == avaliacaoId);
        }
    }
}
