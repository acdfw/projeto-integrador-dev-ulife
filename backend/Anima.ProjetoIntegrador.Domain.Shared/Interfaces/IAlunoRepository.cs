using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IAlunoRepository
    {
        IList<AvaliacaoPendenteTurmaAlunoResponse> ConsultarTurmasProfessoresAvaliacoesPendentes(Guid id);
        IList<TurmaNaoMatriculadaAlunoResponse> ConsultarTurmasNaoMatriculadas(Guid id);
        IList<ProvaAbertaRealizadaPorTurmaAlunoResponse> ConsultarAvaliacoesAbertasRealizadasDeUmaTurma(Guid id, Guid idTurma);
        IList<ProvaAbertaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesAbertasRealizadasDeUmaTurma(Guid id);
    }
}
