using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IAlunoService
    {
        IList<ProvaAbertaRealizadaPorTurmaAlunoResponse> ConsultarAvaliacoesDeUmaTurmaMatriculada(Guid id, Guid idTurma);
        IList<ProvaAbertaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesTurmasMatriculadas(Guid id);
        IList<TurmaMatriculaAlunoResponse> ConsultarTurmasMatriculadasOuNaoDoAluno(Guid id);
    }
}
