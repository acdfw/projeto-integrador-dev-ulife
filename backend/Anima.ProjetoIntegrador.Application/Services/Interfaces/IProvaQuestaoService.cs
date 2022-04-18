using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IProvaQuestaoService
    {
        NovaProvaQuestaoResponse Criar(NovaProvaQuestaoRequest request);
    }
}
