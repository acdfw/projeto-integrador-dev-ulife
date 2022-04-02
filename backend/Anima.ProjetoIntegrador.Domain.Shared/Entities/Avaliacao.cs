using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Avaliacao : Entity
    {
        public Guid? TurmaId { get; set; }
        public virtual Turma? Turma { get; set; }
        public Guid? ProvaId { get; set; }
        public virtual Prova? Prova { get; set; }
        public virtual ICollection<AvaliacaoMatricula>? AvaliacoesMatriculas { get; set; }
    }
}
