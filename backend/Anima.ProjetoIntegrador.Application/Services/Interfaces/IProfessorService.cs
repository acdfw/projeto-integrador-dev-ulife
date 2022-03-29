using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IProfessorService
    {
        IList<TurmaInscritoProfessorResponse> ConsultarTurmasQuantidadeInscritos(Guid id);
        IList<AvaliacaoDisponivelTurmaProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id);
    }
}
