using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IQuestaoService
    {
        NovaQuestaoResponse Criar(NovaQuestaoRequest request);

        QuestaoAlternativaResponse? ConsultarAlternativasPorQuestao(Guid id);
    }
}
