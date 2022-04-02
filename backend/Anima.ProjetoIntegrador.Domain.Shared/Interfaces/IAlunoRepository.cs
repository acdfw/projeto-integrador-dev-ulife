using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        IList<TurmaMatriculaAlunoResponse> ConsultarTurmasMatriculadasOuNaoDoAluno(Guid id);
        IList<ProvaAbertaRealizadaPorTurmaAlunoResponse> ConsultarAvaliacoesAbertasRealizadasDeUmaTurma(Guid id, Guid idTurma);
        IList<ProvaAbertaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesAbertasRealizadasNasTurmasMatriculadas(Guid id);
    }
}
