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
                            NomeAvaliacao = avaliacao.Nome,
                            NomeTurma = turma.Nome,
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
                        join folhaResposta in _context.Set<FolhaResposta>()
                            on avaliacaoMatriculaLefted.Id equals folhaResposta.AvaliacaoMatriculaId
                        into folhaRespostaLeft
                        from folhaRespostaLefted in folhaRespostaLeft.DefaultIfEmpty()
                        join aluno in _context.Set<Aluno>()
                            on matricula.AlunoId equals aluno.Id
                        join usuario in _context.Set<Usuario>()
                            on aluno.UsuarioId equals usuario.Id
                        where avaliacao.Id == id
                        select new AlunoMatriculadoTurmaResponse
                        {
                            FolhaRepostaId = folhaRespostaLefted.Id.ToString(),
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
    }
}
