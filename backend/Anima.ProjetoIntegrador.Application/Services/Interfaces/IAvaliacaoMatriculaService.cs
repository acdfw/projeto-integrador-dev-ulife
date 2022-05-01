using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IAvaliacaoMatriculaService
    {
        object ConsultarRespostasDoAlunoPorAvaliacao(Guid avaliacaoMatriculaId);
        AvaliacaoMatriculaResponse ResponderAvaliacao(AvaliacaoMatriculaRequest request);
    }
}
