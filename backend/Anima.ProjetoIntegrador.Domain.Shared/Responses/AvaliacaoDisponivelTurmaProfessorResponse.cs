namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class AvaliacaoDisponivelTurmaProfessorResponse : BaseResponse
    {
        public string? IdTurma { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProva { get; set; }
        public string? ModeloProva { get; set; }
    }
}
