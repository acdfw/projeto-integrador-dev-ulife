using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Aluno : Entity
    {
        public Guid UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<Matricula>? Matriculas { get; set; }
    }
}
