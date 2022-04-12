using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Prova : Entity
    {
        public Prova() : base(Guid.NewGuid())
        {

        }

        public string? Nome { get; set; }
        public Guid ProfessorId { get; set; }
        public virtual Professor? Professor { get; set; }
        public virtual ICollection<Avaliacao>? Avaliacoes { get; set; }
        public virtual ICollection<ProvaQuestao>? ProvasQuestoes { get; set; }
    }
}
