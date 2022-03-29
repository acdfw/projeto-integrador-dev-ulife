using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IProvaService
    {
        IList<ProvaResponse> ConsultarQuestoesPorProva(Guid id);
    }
}
