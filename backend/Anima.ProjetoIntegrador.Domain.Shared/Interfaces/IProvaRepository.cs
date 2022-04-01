using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IProvaRepository
    {
        IList<QuestaoResponse> ConsultarQuestoesPorProva(Guid idProva);
    }
}
