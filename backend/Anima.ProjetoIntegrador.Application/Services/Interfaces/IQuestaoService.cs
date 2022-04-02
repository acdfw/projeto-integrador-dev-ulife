using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IQuestaoService
    {
        QuestaoAlternativaResponse? ConsultarAlternativasPorQuestao(Guid id);
    }
}
