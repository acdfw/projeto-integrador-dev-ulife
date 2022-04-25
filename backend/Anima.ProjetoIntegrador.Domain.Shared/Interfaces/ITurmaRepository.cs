using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface ITurmaRepository
    {
        IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid id);
        IList<TurmaAlunoMatriculaResponse> ConsultarInscritosPorTurma(Guid id);
        IList<TurmaResponse> ConsultarTurmas();
        TurmaResponse? ObterPorId(Guid id);
        Guid Criar(Turma turma);
    }
}
