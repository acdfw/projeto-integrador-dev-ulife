namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class ProvaAbertaRealizadaTodasTurmasAlunoResponse : BaseResponse
    {
        public string? IdAvaliacao { get; set; }
        public string? NomeProva { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProfessor { get; set; }
        public bool Realizada { get; set; }
    }
}
