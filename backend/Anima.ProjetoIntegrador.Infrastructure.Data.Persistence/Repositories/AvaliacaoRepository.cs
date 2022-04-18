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
                        join prova in _context.Set<Prova>()
                            on avaliacao.ProvaId equals prova.Id
                        where avaliacao.Id == id
                        select new AvaliacaoProvaResponse
                        {
                            ProvaId = prova.Id.ToString(),
                            NomeProva = prova.Nome,
                            NomeAvaliacao = avaliacao.Nome
                        };

            return query.FirstOrDefault();
        }

        public IList<AlunoMatriculadoTurmaResponse> ConsultarTurmaInscritosPorAvaliacao(Guid id)
        {
            var query = from avaliacao in _context.Set<Avaliacao>()
                        join turma in _context.Set<Turma>()
                            on avaliacao.TurmaId equals turma.Id
                        join avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                            on avaliacao.Id equals avaliacaoMatricula.AvaliacaoId
                        join matricula in _context.Set<Matricula>()
                            on turma.Id equals matricula.TurmaId
                        join aluno in _context.Set<Aluno>()
                            on matricula.AlunoId equals aluno.Id
                        join usuario in _context.Set<Usuario>()
                            on aluno.UsuarioId equals usuario.Id
                        where avaliacao.Id == id
                        select new AlunoMatriculadoTurmaResponse
                        {
                            Matricula = matricula.Id.ToString(),
                            NomeAluno = usuario.Nome,
                            NomeTurma = turma.Nome,
                            Nota = avaliacaoMatricula.Nota
                        };

            return query.ToList();
        }

        public Guid Criar(Avaliacao avaliacao)
        {
            return Add(avaliacao).Id;
        }        
    }
}
