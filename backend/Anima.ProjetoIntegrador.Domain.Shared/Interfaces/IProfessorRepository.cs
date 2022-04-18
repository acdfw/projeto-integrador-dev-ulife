using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IProfessorRepository
    {
        IList<TurmaResponse> ConsultarTurmas(Guid id);
        IList<TurmaAlunoMatriculaResponse> ConsultarInscritosDasSuasTurmas(Guid id);        
        IList<AvaliacaoDisponivelTurmaProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id);
    }
}
