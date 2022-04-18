using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IAvaliacaoService
    {
        ProvaTurmaQuestoesResponse? ObterProvaTurmaQuestoesPorAvaliacao(Guid id);
        IList<AlunoMatriculadoTurmaResponse> ConsultarTurmaInscritosPorAvaliacao(Guid id);
        NovaAvaliacaoResponse CriarComProva(NovaAvaliacaoRequest request);
    }
}
