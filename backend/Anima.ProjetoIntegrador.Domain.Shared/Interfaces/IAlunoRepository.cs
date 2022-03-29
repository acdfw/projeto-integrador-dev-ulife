using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IAlunoRepository
    {
        IList<AvaliacaoPendenteTurmaAlunoResponse> ConsultarTurmasProfessoresAvaliacoesPendentes(Guid id);
        IList<TurmaNaoMatriculadaAlunoResponse> ConsultarTurmasNaoMatriculas(Guid id);
        IList<ProvaAbertaPorTurmaAlunoResponse> ConsultarAvaliacoesAbertasDeUmaTurma(Guid id, Guid idTurma);
        IList<ProvaRealizadaPorTurmaAlunoResponse> ConsultarAvaliacoesRealizadasDeUmaTurma(Guid id, Guid idTurma);
        IList<ProvaAbertaTodasTurmasAlunoResponse> ConsultarAvaliacoesAbertasNasTurmaMatriculadas(Guid id);
        IList<ProvaRealizadaTodasTurmasAlunoResponse> ConsultarAvaliacoesRealizadasNasTurmaMatriculadas(Guid id);
    }
}
