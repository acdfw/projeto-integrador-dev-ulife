using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Usuario : Entity
    {
        public string? Nome { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? Role { get; set; }
    }
}
