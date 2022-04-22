using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IAvaliacaoMatriculaRepository
    {
        IList<AvaliacaoRealizadaTurmaResponse> ConsultarAvaliacoesTurmas();
    }
}
