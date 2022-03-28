using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    [ExcludeFromCodeCoverage]
    public class Alternativa : Entity
    {
        public Guid QuestaoId { get; set; }
        public string? Texto { get; set; }
        public bool AlternativaCorreta { get; set; }
    }
}
