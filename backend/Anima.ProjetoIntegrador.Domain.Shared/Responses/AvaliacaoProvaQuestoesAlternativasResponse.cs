namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class AvaliacaoProvaQuestoesAlternativasResponse : BaseResponse
    {
        public string? NomeAvaliacao { get; set; }
        public string? NomeProva { get; set; }
        public IList<QuestaoResponse> Questoes { get; set; }
    }
}
