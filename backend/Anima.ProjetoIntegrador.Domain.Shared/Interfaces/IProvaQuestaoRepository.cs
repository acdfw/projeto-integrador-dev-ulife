using Anima.ProjetoIntegrador.Domain.Entities;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IProvaQuestaoRepository
    {
        Guid Criar(ProvaQuestao provaQuestao);
    }
}
