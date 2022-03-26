using Anima.ProjetoIntegrador.Domain.Shared.Entities;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    public class Alternativa : Entity
    {
        public Guid QuestaoId { get; set; }
        public string Texto { get; set; }
        public bool E_Resposta { get; set; }
    }
}
