namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class AvaliacaoProvaQuestoesAlternativasResponse : BaseResponse
    {
        public string? NomeProva { get; set; }
        public string? NomeAvaliacao { get; set; }
        public IList<QuestaoResponse> Questoes { get; set; }
    }
}
