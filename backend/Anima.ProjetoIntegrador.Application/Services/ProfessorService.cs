using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public IList<TurmaQuantidadeInscritosAvaliacoesProfessorResponse> ConsultarTurmasQuantidadeInscritosAvaliacoes(Guid id)
        {
            var turmasInscritosAvaliacoes = new List<TurmaQuantidadeInscritosAvaliacoesProfessorResponse>();
            var turmas = _professorRepository.ConsultarTurmas(id);
            var avaliacoes = _professorRepository.ConsultarAvaliacoesDasSuasTurmas(id);
            var inscritos = _professorRepository.ConsultarInscritosDasSuasTurmas(id);
            var qtdAvaliacoesPorTurma = avaliacoes.GroupBy(a => a.IdTurma).ToDictionary(a => a.Key, a => a.Count());
            var qtdInscritosPorTurma = inscritos.GroupBy(a => a.IdTurma).ToDictionary(a => a.Key, a => a.Count());

            foreach (var turma in turmas)
            {
                var turmaInscritoAvaliacao = new TurmaQuantidadeInscritosAvaliacoesProfessorResponse
                {
                    IdTurma = turma.Id,
                    NomeTurma = turma.NomeTurma
                };

                var existeQtdAvaliacoes = qtdAvaliacoesPorTurma.TryGetValue(turma.Id, out var qtdAvaliacoes);
                if (existeQtdAvaliacoes)
                {
                    turmaInscritoAvaliacao.QuantidadeAvaliacoes = qtdAvaliacoes;
                }

                var existeQtdInscritos = qtdInscritosPorTurma.TryGetValue(turma.Id, out var qtdInscritos);
                if (existeQtdInscritos)
                {
                    turmaInscritoAvaliacao.QuantidadeInscritos = qtdInscritos;
                }

                turmasInscritosAvaliacoes.Add(turmaInscritoAvaliacao);
            }

            return turmasInscritosAvaliacoes;
        }

        public IList<AvaliacaoDisponivelTurmaProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id)
        {
            return _professorRepository.ConsultarAvaliacoesDasSuasTurmas(id);
        }
    }
}
