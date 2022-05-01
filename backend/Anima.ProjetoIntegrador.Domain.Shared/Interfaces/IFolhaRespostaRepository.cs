using Anima.ProjetoIntegrador.Domain.Entities;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IFolhaRespostaRepository
    {
        IList<FolhaResposta> ConsultarRespostasPorAvaliacao(Guid? avaliacaoMatriculaId);
    }
}
