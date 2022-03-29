using Anima.ProjetoIntegrador.Application.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IProvaRepository
    {
        IList<ProvaResponse> ConsultarQuestoesPorProva(Guid idProva);
    }
}
