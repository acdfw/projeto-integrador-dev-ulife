namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class ProvaTurmaQuestoesResponse : BaseResponse
    {
        public string IdentificadorProva { get; set; }
        public string? NomeTurma { get; set; }
        public IList<QuestaoResponse> Questoes { get; set; }
    }
}
