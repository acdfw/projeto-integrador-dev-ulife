using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IProfessorRepository
    {
        IList<TurmaResponse> ConsultarTurmas(Guid id);
        IList<TurmaAlunoMatriculaResponse> ConsultarInscritosDasSuasTurmas(Guid id);        
        IList<AvaliacaoProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id);
        IList<ProvaProfessorResponse> ConsultarProvasDoProfessor(Guid id);
        Guid ObterProfessorPorUsuario(Guid usuarioId);
    }
}
