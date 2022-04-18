using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IAvaliacaoService
    {
        AvaliacaoProvaQuestoesAlternativasResponse? ObterProvaTurmaQuestoesPorAvaliacao(Guid id);
        IList<AlunoMatriculadoTurmaResponse> ConsultarTurmaInscritosPorAvaliacao(Guid id);
        NovaAvaliacaoResponse Criar(NovaAvaliacaoRequest request);
    }
}
