using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        private readonly IAvaliacaoMatriculaRepository _avaliacaoMatriculaRepository;

        public ProfessorService(IProfessorRepository professorRepository, IAvaliacaoMatriculaRepository avaliacaoMatriculaRepository)
        {
            _professorRepository = professorRepository;
            _avaliacaoMatriculaRepository = avaliacaoMatriculaRepository;
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

        public IList<AvaliacaoProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id)
        {
            var avaliacoesProfessor = _professorRepository.ConsultarAvaliacoesDasSuasTurmas(id);
            var avaliacoesRealizadas = _avaliacaoMatriculaRepository.ConsultarAvaliacoesTurmas();
            
            if(avaliacoesProfessor.Any() && avaliacoesRealizadas.Any())
            {
                var avaliacoesProfessorAgrupadas = avaliacoesProfessor.GroupBy(a => (a.IdTurma, a.IdAvaliacao)).ToDictionary(a => a.Key, a => a.Single());
                var avaliacoesRealizadasAgrupadas = avaliacoesRealizadas.GroupBy(a => (a.IdTurma, a.IdAvaliacao)).ToDictionary(a => a.Key, a => a.Count());
                foreach (var avaliacao in avaliacoesProfessorAgrupadas)
                {
                    var existeQtdRealizadas = avaliacoesRealizadasAgrupadas
                        .TryGetValue((avaliacao.Key.IdTurma, avaliacao.Key.IdAvaliacao), out var qtdRealizadas);
                    if (existeQtdRealizadas)
                    {
                        avaliacao.Value.QtdRealizadas = qtdRealizadas;
                    }
                }
            }

            return avaliacoesProfessor;
        }
    }
}
