using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IProfessorService
    {
        IList<TurmaQuantidadeInscritosAvaliacoesProfessorResponse> ConsultarTurmasQuantidadeInscritosAvaliacoes(Guid id);
        IList<AvaliacaoProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id);
    }
}
