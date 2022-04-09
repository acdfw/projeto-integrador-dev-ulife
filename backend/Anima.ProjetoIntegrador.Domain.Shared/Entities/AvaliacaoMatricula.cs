using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class AvaliacaoMatricula : Entity
    {
        public AvaliacaoMatricula() : base(Guid.NewGuid())
        {

        }

        public Guid? AvaliacaoId { get; set; }
        public virtual Avaliacao? Avaliacao { get; set; }
        public Guid? MatriculaId { get; set; }
        public virtual Matricula? Matricula { get; set; }
        public double Nota { get; set; }
    }
}
