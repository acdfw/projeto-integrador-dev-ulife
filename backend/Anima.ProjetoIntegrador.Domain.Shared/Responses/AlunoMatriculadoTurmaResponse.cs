namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class AlunoMatriculadoTurmaResponse : BaseResponse
    {
        public string? Matricula { get; set; }
        public string? NomeAluno { get; set; }
        public double? Nota { get; set; }
        public string? AvaliacaoId { get; set; }
    }
}
