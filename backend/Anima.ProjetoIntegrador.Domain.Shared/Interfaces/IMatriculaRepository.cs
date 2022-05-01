namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IMatriculaRepository
    {
        Guid ObterPorAluno(Guid usuarioId);
    }
}
