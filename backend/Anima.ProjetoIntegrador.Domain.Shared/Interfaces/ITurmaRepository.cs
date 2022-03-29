using Anima.ProjetoIntegrador.Application.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface ITurmaRepository
    {
        IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid idTurma);
        IList<AlunoMatriculaPorTurmaResponse> ConsultarAlunosMatriculadosPorTurma(Guid idTurma);
    }
}
