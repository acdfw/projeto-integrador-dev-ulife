namespace Anima.ProjetoIntegrador.Domain.Requests
{
    public class AvaliacaoMatriculaRequest
    {
        public string? AvaliacaoId { get; set; }
        public string? UsuarioId { get; set; }
        public IList<FolhaRespostaRequest>? Respostas { get; set; }
    }
}
