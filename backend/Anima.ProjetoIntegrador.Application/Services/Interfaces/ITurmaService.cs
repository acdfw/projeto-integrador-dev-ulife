using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface ITurmaService
    {
        IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid id);
        IList<AlunoMatriculaPorTurmaResponse> ConsultarAlunosMatriculadosPorTurma(Guid id);
    }
}
