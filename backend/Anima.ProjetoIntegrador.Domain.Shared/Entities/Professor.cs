using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Professor : Entity
    {
        public Professor() : base(Guid.NewGuid())
        {

        }

        public Guid UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<Turma>? Turmas { get; set; }
        public virtual ICollection<Prova>? Provas { get; set; }
        public virtual ICollection<Questao>? Questoes { get; set; }
    }
}
