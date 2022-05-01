namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class ProvaAbertaRealizadaTodasTurmasAlunoResponse : BaseResponse
    {
        public string? AvaliacaoId { get; set; }
        public string? NomeAvaliacao { get; set; }
        public string? TurmaId { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProfessor { get; set; }
        public double? Nota { get; set; }
        public string? AvaliacaoMatriculaId { get; set; }
    }
}
