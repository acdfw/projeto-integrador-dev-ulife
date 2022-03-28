using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    [ExcludeFromCodeCoverage]
    public class Turma : Entity
    {
        public string? Nome { get; set; }
        public Guid ProfessorId { get; set; }
        public virtual Professor? Professor { get; set; }
        public virtual ICollection<Avaliacao>? Avaliacoes { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
