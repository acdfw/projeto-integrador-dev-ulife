using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Alternativa : Entity
    {
        public Guid QuestaoId { get; set; }
        public string? Texto { get; set; }
        public bool AlternativaCorreta { get; set; }
    }
}
