using Anima.ProjetoIntegrador.Domain.Shared.Entities;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    public class Usuario : Entity
    {
        public Usuario() : base(Guid.NewGuid())
        {
        }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
