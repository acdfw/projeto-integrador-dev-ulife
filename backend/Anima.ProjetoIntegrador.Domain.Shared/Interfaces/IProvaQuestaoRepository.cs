using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IProvaQuestaoRepository
    {
        IList<ProvaQuestaoResponse> ConsultarProvaQuestaoDoProfessor(Guid idProfessor);
        Guid Criar(ProvaQuestao provaQuestao);
        void Criar(IEnumerable<ProvaQuestao> provasQuestao);
    }
}
