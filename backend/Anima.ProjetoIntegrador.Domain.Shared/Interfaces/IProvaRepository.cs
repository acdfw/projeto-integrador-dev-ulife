using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IProvaRepository
    {
        IList<QuestaoResponse> ConsultarQuestoesPorProva(Guid idProva);
        Guid Criar(Prova prova);
        Prova? ObterPorId(Guid id);
    }
}
