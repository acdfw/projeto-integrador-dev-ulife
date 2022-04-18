namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class TurmaQuantidadeInscritosAvaliacoesProfessorResponse : BaseResponse
    {
        public string? IdTurma { get; set; }
        public string? NomeTurma { get; set; }
        public int QuantidadeInscritos { get; set; }
        public int QuantidadeAvaliacoes { get; set; }
    }
}
