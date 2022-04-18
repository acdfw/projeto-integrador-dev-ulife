namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class TurmaAlunoMatriculaResponse : BaseResponse
    {
        public string? IdTurma { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeAluno { get; set; }
        public string? Matricula { get; set; }
    }
}
