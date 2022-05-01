using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IAvaliacaoMatriculaRepository
    {
        IList<AvaliacaoRealizadaTurmaResponse> ConsultarAvaliacoesTurmas();
        AvaliacaoMatricula? ObterPorId(Guid avaliacaoMatriculaId);
    }
}
