using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IProvaService
    {
        ProvaResponse ConsultarQuestoesPorProva(Guid id);
        NovaProvaResponse Criar(NovaProvaRequest request);
    }
}
