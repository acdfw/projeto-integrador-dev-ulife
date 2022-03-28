using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    [ExcludeFromCodeCoverage]
    public class Professor : Entity
    {
        public Guid UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<Turma>? Turmas { get; set; }
        public virtual ICollection<Prova>? Provas { get; set; }
        public virtual ICollection<Questao>? Questoes { get; set; }
    }
}
