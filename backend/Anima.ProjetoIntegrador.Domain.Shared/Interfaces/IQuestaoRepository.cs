using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IQuestaoRepository
    {
        IList<AlternativaResponse> ConsultarAlternativasPorQuestao(Guid idQuestao);
        QuestaoResponse? ObterPorId(Guid id);
    }
}
