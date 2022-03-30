using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public IList<ProvaAbertaRealizadaPorTurmaAlunoResponse> ConsultarAvaliacoesDeUmaTurmaMatriculada(Guid id, Guid idTurma)
        {
            var avaliacoes = _alunoRepository.ConsultarAvaliacoesAbertasRealizadasDeUmaTurma(id, idTurma);

            return avaliacoes;
        }

        public IList<ProvaAbertaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesTurmasMatriculadas(Guid id)
        {
            var avaliacoes = _alunoRepository.ConsultarAvaliacoesAbertasRealizadasNasTurmasMatriculadas(id);

            return avaliacoes;
        }

        public IList<TurmaMatriculaAlunoResponse> ConsultarTurmasMatriculadasOuNaoDoAluno(Guid id)
        {
            var turmas = _alunoRepository.ConsultarTurmasMatriculadasOuNaoDoAluno(id);

            return turmas;
        }
    }
}
