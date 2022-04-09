using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IAlternativaService
    {
        NovaAlternativaResponse Criar(NovaAlternativaRequest request);
    }
}
