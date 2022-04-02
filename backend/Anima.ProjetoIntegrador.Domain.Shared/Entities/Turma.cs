using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Turma : Entity
    {
        public string? Nome { get; set; }
        public Guid ProfessorId { get; set; }
        public virtual Professor? Professor { get; set; }
        public virtual ICollection<Avaliacao>? Avaliacoes { get; set; }
        public virtual ICollection<Matricula>? Matriculas { get; set; }
    }
}
