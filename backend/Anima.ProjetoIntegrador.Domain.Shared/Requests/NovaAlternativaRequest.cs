namespace Anima.ProjetoIntegrador.Domain.Requests
{
    public class NovaAlternativaRequest
    {
        public string? QuestaoId { get; set; }
        public string? Texto { get; set; }
        public bool AlternativaCorreta { get; set; }
    }
}
