using Anima.ProjetoIntegrador.Domain.Shared.Entities;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    public class AvaliacaoMatricula : Entity
    {
        public Guid AvaliacaoId { get; set; }
        public virtual Avaliacao Avaliacao { get; set; }
        public Guid MatriculaId { get; set; }
        public virtual Matricula Matricula { get; set; }
        public double Nota { get; set; }
    }
}
