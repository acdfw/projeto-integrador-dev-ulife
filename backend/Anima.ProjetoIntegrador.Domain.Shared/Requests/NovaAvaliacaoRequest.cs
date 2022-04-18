namespace Anima.ProjetoIntegrador.Domain.Requests
{
    public class NovaAvaliacaoRequest
    {
        public string? TurmaId { get; set; }
        public string? ProfessorId { get; set; }
        public string? NomeProva { get; set; }
    }
}
