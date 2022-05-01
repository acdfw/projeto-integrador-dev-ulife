namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class ProvaResponse : BaseResponse
    {
        public string? Nome { get; set; }
        public IList<QuestaoResponse>? Questoes { get; set; }
    }
}
