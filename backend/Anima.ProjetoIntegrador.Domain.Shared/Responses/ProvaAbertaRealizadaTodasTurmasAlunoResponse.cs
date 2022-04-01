namespace Anima.ProjetoIntegrador.Domain.Shared.Responses
{
    public class ProvaAbertaRealizadaTodasTurmasAlunoResponse
    {
        public string? IdAvaliacao { get; set; }
        public string? NomeProva { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProfessor { get; set; }
        public bool Realizada { get; set; }
    }
}
