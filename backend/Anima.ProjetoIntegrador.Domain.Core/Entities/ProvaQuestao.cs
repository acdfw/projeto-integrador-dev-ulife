using Anima.ProjetoIntegrador.Domain.Shared.Entities;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    public class ProvaQuestao : Entity
    {
        public Guid ProvaId { get; set; }
        public virtual Prova Prova { get; set; }
        public Guid QuestaoId { get; set; }
        public virtual Questao Questao { get; set; }
    }
}
