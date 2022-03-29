namespace Anima.ProjetoIntegrador.Domain.Shared.Responses
{
    public class QuestaoAlternativaResponse
    {
        public string? IdQuestao { get; set; }
        public string? Enunciado { get; set; }
        public IList<AlternativaResponse>? Alternativas { get; set; }
    }
}
