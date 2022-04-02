using Anima.ProjetoIntegrador.Domain.Requests;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IAlternativaService
    {
        string Criar(NovaAlternativaRequest request);
    }
}
