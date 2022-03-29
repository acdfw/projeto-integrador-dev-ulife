using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IQuestaoService
    {
        QuestaoAlternativaResponse? ConsultarAlternativasPorQuestao(Guid id);
    }
}
