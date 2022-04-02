using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IProvaService
    {
        IList<QuestaoResponse> ConsultarQuestoesPorProva(Guid id);
    }
}
