using Anima.ProjetoIntegrador.Application.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IAlunoRepository
    {
        IList<AvaliacoesPendentesTurmaAlunoResponse> ConsultarTurmasProfessoresAvaliacoesPendentes(Guid id);

        IList<TurmasNaoMatriculasAlunoResponse> ConsultarTurmasNaoMatriculas(Guid id);

        IList<ProvasAbertasTurmaAlunoResponse> ConsultarAvaliacoesAbertasDeUmaTurma(Guid id, Guid idTurma);
        IList<ProvasRealizadasTurmaAlunoResponse> ConsultarAvaliacoesRealizadasDeUmaTurma(Guid id, Guid idTurma);
        IList<ProvasAbertasTodasTurmasAlunoResponse> ConsultarAvaliacoesAbertasNasTurmaMatriculadas(Guid id);
        IList<ProvasRealizadasTodasTurmasAlunoResponse> ConsultarAvaliacoesRealizadasNasTurmaMatriculadas(Guid id);
    }
}
