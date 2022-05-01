namespace Anima.ProjetoIntegrador.Domain.Requests
{
    public class NovaProvaRequest
    {
        public string? Nome { get; set; }
        public string? UsuarioId { get; set; }
        public IList<string?> QuestoesId { get; set; }
    }
}
