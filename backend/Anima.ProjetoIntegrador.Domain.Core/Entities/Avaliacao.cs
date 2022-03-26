using Anima.ProjetoIntegrador.Domain.Shared.Entities;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    public class Avaliacao : Entity
    {
        public Guid TurmaId { get; set; }
        public virtual Turma Turma { get; set; }
        public Guid ProvaId { get; set; }
        public virtual Prova Prova { get; set; }
        public virtual ICollection<AvaliacaoMatricula> AvaliacoesMatriculas { get; set; }
    }
}
