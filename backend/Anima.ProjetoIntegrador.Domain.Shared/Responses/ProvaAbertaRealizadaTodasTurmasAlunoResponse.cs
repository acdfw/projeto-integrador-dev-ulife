namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class ProvaAbertaRealizadaTodasTurmasAlunoResponse : BaseResponse
    {
        public string? IdAvaliacao { get; set; }
        public string? NomeAvaliacao { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProfessor { get; set; }
        public double? Nota { get; set; }
        public bool Realizada { get; set; }
    }
}
