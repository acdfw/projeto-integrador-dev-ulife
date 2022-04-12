using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface ITurmaService
    {
        IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid id);
        IList<AlunoMatriculaPorTurmaResponse> ConsultarAlunosMatriculadosPorTurma(Guid id);
        NovaTurmaResponse Criar(NovaTurmaRequest request);
    }
}
