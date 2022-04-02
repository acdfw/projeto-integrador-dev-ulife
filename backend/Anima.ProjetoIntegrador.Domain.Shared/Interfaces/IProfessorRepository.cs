using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IProfessorRepository
    {
        IList<TurmaInscritoProfessorResponse> ConsultarTurmasQuantidadeInscritos(Guid id);        
        IList<AvaliacaoDisponivelTurmaProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id);
    }
}
