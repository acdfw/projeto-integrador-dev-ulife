using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IAlternativaRepository
    {
        Guid Criar(Alternativa alternativa);
        int Criar(IEnumerable<Alternativa> alternativas);
        Guid Alterar(Alternativa alternativa);        
        IList<AlternativaResponse> ConsultarPorQuestoes(IEnumerable<Guid> questoesId);
    }
}
