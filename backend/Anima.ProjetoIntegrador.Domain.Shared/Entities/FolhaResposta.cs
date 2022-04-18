using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class FolhaResposta : Entity
    {
        public FolhaResposta() : base(Guid.NewGuid())
        {

        }

        public Guid? AvaliacaoMatriculaId { get; set; }
        public AvaliacaoMatricula? AvaliacaoMatricula { get; set; }
        public Guid? QuestaoId { get; set; }
        public Questao? Questao { get; set; }
        public Guid? AlternativaId { get; set; }
        public Alternativa? Alternativa { get; set; }
    }
}
