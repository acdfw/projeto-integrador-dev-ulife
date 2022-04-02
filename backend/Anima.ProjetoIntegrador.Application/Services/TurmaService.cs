using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaService(ITurmaRepository turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }

        public IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid id)
        {
            return _turmaRepository.ConsultarAvaliacoesPorTurma(id);
        }

        public IList<AlunoMatriculaPorTurmaResponse> ConsultarAlunosMatriculadosPorTurma(Guid id)
        {
            return _turmaRepository.ConsultarAlunosMatriculadosPorTurma(id);
        }
    }
}
