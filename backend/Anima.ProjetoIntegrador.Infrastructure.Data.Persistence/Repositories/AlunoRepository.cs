using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(IntegradorContext context) : base(context)
        {
        }

        public IList<TurmaMatriculaAlunoResponse> ConsultarTurmasMatriculadasOuNaoDoAluno(Guid id)
        {
            var turmasMatriculadas = ConsultarTurmasMatriculadas(id);

            var turmasNaoMatriculadas = ConsultarTurmasNaoMatriculadas(id);

            return turmasMatriculadas.Union(turmasNaoMatriculadas).ToList();
        }

        private IList<TurmaMatriculaAlunoResponse> ConsultarTurmasMatriculadas(Guid id)
        {
            var query = from aluno in _context.Set<Aluno>()
                        join matricula in _context.Set<Matricula>()
                            on aluno.Id equals matricula.AlunoId
                        join turma in _context.Set<Turma>()
                            on matricula.TurmaId equals turma.Id
                        join professor in _context.Set<Professor>()
                            on turma.ProfessorId equals professor.Id
                        join usuario in _context.Set<Usuario>()
                            on professor.UsuarioId equals usuario.Id
                        where aluno.Id == id
                        select new TurmaMatriculaAlunoResponse
                        {
                            IdTurma = turma.Id.ToString(),
                            NomeTurma = turma.Nome,
                            NomeProfessor = usuario.Nome,
                            Matriculado = true
                        };

            return query.ToList();
        }

        private IList<TurmaMatriculaAlunoResponse> ConsultarTurmasNaoMatriculadas(Guid id)
        {
            var queryTodasTurmas = _context.Set<Turma>().AsQueryable();
            var queryTurmasMatriculadas = from aluno in _context.Set<Aluno>()
                                          join matricula in _context.Set<Matricula>()
                                              on aluno.Id equals matricula.AlunoId
                                          join turma in _context.Set<Turma>()
                                              on matricula.TurmaId equals turma.Id
                                          where aluno.Id == id
                                          select turma;
            var queryTurmasNaoMatriculadas = queryTodasTurmas.Except(queryTurmasMatriculadas);
            var turmasNaoMatriculadas = from turma in queryTurmasNaoMatriculadas
                                        join professor in _context.Set<Professor>()
                                            on turma.ProfessorId equals professor.Id
                                        join usuario in _context.Set<Usuario>()
                                            on professor.UsuarioId equals usuario.Id
                                        select new TurmaMatriculaAlunoResponse
                                        {
                                            IdTurma = turma.Id.ToString(),
                                            NomeTurma = turma.Nome,
                                            NomeProfessor = usuario.Nome,
                                            Matriculado = false
                                        };

            return turmasNaoMatriculadas.ToList();
        }

        public IList<ProvaAbertaRealizadaPorTurmaAlunoResponse> ConsultarAvaliacoesAbertasRealizadasDeUmaTurma(Guid id, Guid idTurma)
        {
            var avaliacoesAbertas = ConsultarAvaliacoesAbertasDeUmaTurma(id, idTurma).Select(p => new ProvaAbertaRealizadaPorTurmaAlunoResponse
            {
                NomeProva = p.NomeProva,                
                Realizada = false
            });

            var avaliacoesRealizadas = ConsultarAvaliacoesRealizadasDeUmaTurma(id, idTurma).Select(p => new ProvaAbertaRealizadaPorTurmaAlunoResponse
            {
                NomeProva = p.NomeProva,
                Nota = p.Nota,
                Realizada = true
            });

            return avaliacoesAbertas.Union(avaliacoesRealizadas).ToList();
        }

        private IList<ProvaAbertaPorTurmaAlunoResponse> ConsultarAvaliacoesAbertasDeUmaTurma(Guid id, Guid idTurma)
        {
            var queryTodasAvaliacoes = from aluno in _context.Set<Aluno>()
                                        join matricula in _context.Set<Matricula>()
                                            on aluno.Id equals matricula.AlunoId
                                        join turma in _context.Set<Turma>()
                                            on matricula.TurmaId equals turma.Id
                                        join avaliacao in _context.Set<Avaliacao>()
                                            on turma.Id equals avaliacao.TurmaId
                                        where aluno.Id == id && turma.Id == idTurma
                                        select avaliacao;

            var queryAvaliacoesDoAluno = from aluno in _context.Set<Aluno>()
                                         join matricula in _context.Set<Matricula>()
                                             on aluno.Id equals matricula.AlunoId
                                         join avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                                            on matricula.Id equals avaliacaoMatricula.MatriculaId
                                         join avaliacao in _context.Set<Avaliacao>()
                                              on avaliacaoMatricula.AvaliacaoId equals avaliacao.Id
                                         join turma in _context.Set<Turma>()
                                             on avaliacao.TurmaId equals turma.Id
                                         where aluno.Id == id && turma.Id == idTurma
                                         select avaliacao;

            var queryAvaliacoesAbertas = queryTodasAvaliacoes.Except(queryAvaliacoesDoAluno);
            var provasAbertas = from avaliacao in queryAvaliacoesAbertas.ToList()
                                join prova in _context.Set<Prova>()
                                    on avaliacao.ProvaId equals prova.Id
                                select new ProvaAbertaPorTurmaAlunoResponse
                                {
                                    NomeProva = prova.Nome
                                };

            return provasAbertas.ToList();
        }

        private IList<ProvaRealizadaPorTurmaAlunoResponse> ConsultarAvaliacoesRealizadasDeUmaTurma(Guid id, Guid idTurma)
        {
            var query = from aluno in _context.Set<Aluno>()
                        join matricula in _context.Set<Matricula>()
                            on aluno.Id equals matricula.AlunoId
                        join avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                           on matricula.Id equals avaliacaoMatricula.MatriculaId
                        join avaliacao in _context.Set<Avaliacao>()
                             on avaliacaoMatricula.AvaliacaoId equals avaliacao.Id
                        join turma in _context.Set<Turma>()
                            on avaliacao.TurmaId equals turma.Id
                        join prova in _context.Set<Prova>()
                            on avaliacao.ProvaId equals prova.Id
                        where aluno.Id == id && turma.Id == idTurma
                        select new ProvaRealizadaPorTurmaAlunoResponse
                        {
                            NomeProva = prova.Nome,
                            Nota = avaliacaoMatricula.Nota
                        };

            return query.ToList();
        }

        public IList<ProvaAbertaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesAbertasRealizadasNasTurmasMatriculadas(Guid id)
        {
            var avaliacoesAbertas = ConsultarAvaliacoesAbertasNasTurmasMatriculadas(id);

            var avaliacoesRealizadas = ConsultarAvaliacoesRealizadasNasTurmasMatriculadas(id);

            return avaliacoesAbertas.Union(avaliacoesRealizadas).ToList();
        }

        private IList<ProvaAbertaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesAbertasNasTurmasMatriculadas(Guid id)
        {
            var queryTodasAvaliacoes = from aluno in _context.Set<Aluno>()
                                       join matricula in _context.Set<Matricula>()
                                           on aluno.Id equals matricula.AlunoId
                                       join turma in _context.Set<Turma>()
                                           on matricula.TurmaId equals turma.Id
                                       join avaliacao in _context.Set<Avaliacao>()
                                           on turma.Id equals avaliacao.TurmaId
                                       where aluno.UsuarioId == id
                                       select avaliacao;

            var queryAvaliacoesDoAluno = from aluno in _context.Set<Aluno>()
                                         join matricula in _context.Set<Matricula>()
                                             on aluno.Id equals matricula.AlunoId
                                         join avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                                            on matricula.Id equals avaliacaoMatricula.MatriculaId
                                         join avaliacao in _context.Set<Avaliacao>()
                                              on avaliacaoMatricula.AvaliacaoId equals avaliacao.Id
                                         join turma in _context.Set<Turma>()
                                             on avaliacao.TurmaId equals turma.Id
                                         where aluno.UsuarioId == id
                                         select avaliacao;

            var queryAvaliacoesAbertasTurmas = queryTodasAvaliacoes.Except(queryAvaliacoesDoAluno);
            var provasAbertasTurmas = from avaliacao in queryAvaliacoesAbertasTurmas.ToList()
                                    join turma in _context.Set<Turma>()
                                        on avaliacao.TurmaId equals turma.Id
                                    join prova in _context.Set<Prova>()
                                        on avaliacao.ProvaId equals prova.Id
                                    join professor in _context.Set<Professor>()
                                        on prova.ProfessorId equals professor.Id
                                    join usuario in _context.Set<Usuario>()
                                        on professor.UsuarioId equals usuario.Id
                                    select new ProvaAbertaRealizadaTodasTurmasAlunoResponse
                                    {
                                        IdAvaliacao = avaliacao.Id.ToString(),
                                        NomeAvaliacao = avaliacao.Nome,
                                        NomeTurma = turma.Nome,
                                        NomeProfessor = usuario.Nome
                                    };

            return provasAbertasTurmas.ToList();
        }

        private IList<ProvaAbertaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesRealizadasNasTurmasMatriculadas(Guid id)
        {
            var query = from aluno in _context.Set<Aluno>()
                        join matricula in _context.Set<Matricula>()
                            on aluno.Id equals matricula.AlunoId
                        join avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                           on matricula.Id equals avaliacaoMatricula.MatriculaId
                        join avaliacao in _context.Set<Avaliacao>()
                             on avaliacaoMatricula.AvaliacaoId equals avaliacao.Id
                        join turma in _context.Set<Turma>()
                            on avaliacao.TurmaId equals turma.Id
                        join prova in _context.Set<Prova>()
                            on avaliacao.ProvaId equals prova.Id
                        join professor in _context.Set<Professor>()
                            on prova.ProfessorId equals professor.Id
                        join usuario in _context.Set<Usuario>()
                            on professor.UsuarioId equals usuario.Id                        
                        where aluno.UsuarioId == id
                        select new ProvaAbertaRealizadaTodasTurmasAlunoResponse
                        {
                            IdAvaliacao = avaliacao.Id.ToString(),
                            NomeAvaliacao = avaliacao.Nome,
                            NomeTurma = turma.Nome,
                            NomeProfessor = usuario.Nome,
                            Nota = avaliacaoMatricula.Nota,
                            AvaliacaoMatriculaId = avaliacaoMatricula.Id.ToString()
                        };

            return query.ToList();
        }     
    }
}
