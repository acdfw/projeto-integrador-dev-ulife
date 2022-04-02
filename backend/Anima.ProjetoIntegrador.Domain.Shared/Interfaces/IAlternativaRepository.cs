using Anima.ProjetoIntegrador.Domain.Entities;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IAlternativaRepository
    {
        Guid Criar(Alternativa alternativa);

        Guid Alterar(Alternativa alternativa);
    }
}
