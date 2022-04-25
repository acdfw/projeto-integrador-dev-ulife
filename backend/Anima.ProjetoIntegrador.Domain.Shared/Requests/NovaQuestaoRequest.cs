namespace Anima.ProjetoIntegrador.Domain.Requests
{
    public class NovaQuestaoRequest
    {
        public string? Enunciado { get; set; }
        public string? Nome { get; set; }
        public string? UsuarioId { get; set; }
        public IList<NovaAlternativaRequest>? Alternativas { get; set; }
    }
}
