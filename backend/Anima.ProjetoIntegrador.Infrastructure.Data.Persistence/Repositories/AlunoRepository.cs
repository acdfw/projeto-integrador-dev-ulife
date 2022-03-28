using Anima.ProjetoIntegrador.Application.Responses;
using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(IntegradorContext context) : base(context)
        {
        }

        public IList<AvaliacoesPendentesTurmaAlunoResponse> ConsultarTurmasProfessoresAvaliacoesPendentes(Guid id)
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
                        select new AvaliacoesPendentesTurmaAlunoResponse
                        {
                            NomeTurma = turma.Nome,
                            NomeProfessor = usuario.Nome
                            // TODO: QtdAnaliacoesPendentes (verificar se conseguimos nesta consulta ou tem que ser em outra)
                        };

            return query.ToList();
        }

        public IList<TurmasNaoMatriculasAlunoResponse> ConsultarTurmasNaoMatriculas(Guid id)
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
                                        select new TurmasNaoMatriculasAlunoResponse
                                        {
                                            NomeTurma = turma.Nome,
                                            ProfessorNome = usuario.Nome
                                        };

            return turmasNaoMatriculadas.ToList();
        }

        public IList<ProvasAbertasTurmaAlunoResponse> ConsultarAvaliacoesAbertasDeUmaTurma(Guid id, Guid idTurma)
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
                                select new ProvasAbertasTurmaAlunoResponse
                                {
                                    NomeProva = prova.Nome
                                };

            return provasAbertas.ToList();
        }

        public IList<ProvasRealizadasTurmaAlunoResponse> ConsultarAvaliacoesRealizadasDeUmaTurma(Guid id, Guid idTurma)
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
                        select new ProvasRealizadasTurmaAlunoResponse
                        {
                            NomeProva = prova.Nome,
                            Nota = avaliacaoMatricula.Nota
                        };

            return query.ToList();
        }

        public IList<ProvasAbertasTodasTurmasAlunoResponse> ConsultarAvaliacoesAbertasNasTurmaMatriculadas(Guid id)
        {
            var queryTodasAvaliacoes = from aluno in _context.Set<Aluno>()
                                       join matricula in _context.Set<Matricula>()
                                           on aluno.Id equals matricula.AlunoId
                                       join turma in _context.Set<Turma>()
                                           on matricula.TurmaId equals turma.Id
                                       join avaliacao in _context.Set<Avaliacao>()
                                           on turma.Id equals avaliacao.TurmaId
                                       where aluno.Id == id
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
                                         where aluno.Id == id
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
                                select new ProvasAbertasTodasTurmasAlunoResponse
                                {
                                    NomeProva = prova.Nome,
                                    NomeTurma = turma.Nome,
                                    NomeProfessor = usuario.Nome
                                };

            return provasAbertasTurmas.ToList();
        }        

        public IList<ProvasRealizadasTodasTurmasAlunoResponse> ConsultarAvaliacoesRealizadasNasTurmaMatriculadas(Guid id)
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
                        where aluno.Id == id
                        select new ProvasRealizadasTodasTurmasAlunoResponse
                        {
                            NomeProva = prova.Nome,
                            NomeTurma = turma.Nome,
                            NomeProfessor = usuario.Nome
                        };

            return query.ToList();
        }     
    }
}
