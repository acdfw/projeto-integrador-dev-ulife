using Anima.ProjetoIntegrador.Application.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IQuestaoRepository
    {
        IList<AlternativaResponse> ConsultarAlternativasPorQuestao(Guid idQuestao);
    }
}
