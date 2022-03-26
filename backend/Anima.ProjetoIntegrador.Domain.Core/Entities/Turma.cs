using Anima.ProjetoIntegrador.Domain.Shared.Entities;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    public class Turma : Entity
    {
        public string Nome { get; set; }
        public Guid ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}
