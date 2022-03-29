using Anima.ProjetoIntegrador.Application.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IProfessorRepository
    {
        IList<TurmaInscritoProfessorResponse> ConsultarTurmasQuantidadeInscritos(Guid id);        
        IList<AvaliacaoDisponivelTurmaProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id);
    }
}
