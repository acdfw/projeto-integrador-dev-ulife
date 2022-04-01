using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IAlunoRepository
    {
        IList<TurmaMatriculaAlunoResponse> ConsultarTurmasMatriculadasOuNaoDoAluno(Guid id);
        IList<ProvaAbertaRealizadaPorTurmaAlunoResponse> ConsultarAvaliacoesAbertasRealizadasDeUmaTurma(Guid id, Guid idTurma);
        IList<ProvaAbertaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesAbertasRealizadasNasTurmasMatriculadas(Guid id);
    }
}
