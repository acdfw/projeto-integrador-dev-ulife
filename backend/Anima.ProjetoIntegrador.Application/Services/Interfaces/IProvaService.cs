using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IProvaService
    {
        IList<QuestaoResponse> ConsultarQuestoesPorProva(Guid id);
    }
}
