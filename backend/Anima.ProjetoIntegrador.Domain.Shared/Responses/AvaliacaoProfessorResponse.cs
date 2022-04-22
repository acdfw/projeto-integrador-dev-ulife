namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class AvaliacaoProfessorResponse : BaseResponse
    {
        public string? IdTurma { get; set; }
        public string? IdAvaliacao { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProva { get; set; }
        public string? NomeAvaliacao { get; set; }
        public int QtdRealizadas { get; set; }
    }
}
