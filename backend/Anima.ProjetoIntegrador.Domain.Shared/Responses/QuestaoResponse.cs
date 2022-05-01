namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class QuestaoResponse : BaseResponse
    {
        public string? Id { get; set; }
        public string? Enunciado { get; set; }
        public string? NomeQuestao { get; set; }
        public IList<AlternativaResponse>? Alternativas { get; set; }
        public string? AlternativaCorretaId { get; set; }
        public string? AlternativaRespondidaId { get; set; }
    }
}
