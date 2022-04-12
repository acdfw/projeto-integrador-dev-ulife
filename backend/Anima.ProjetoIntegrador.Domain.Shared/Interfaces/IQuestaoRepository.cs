using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IQuestaoRepository
    {
        IList<AlternativaResponse> ConsultarAlternativasPorQuestao(Guid idQuestao);
        QuestaoResponse? ObterPorId(Guid id);
        Guid Criar(Questao questao);
    }
}
