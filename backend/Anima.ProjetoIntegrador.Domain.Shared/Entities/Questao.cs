using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Questao : Entity
    {
        public string? Enunciado { get; set; }
        public Guid ProfessorId { get; set; }
        public virtual Professor? Professor { get; set; }
        public virtual ICollection<Alternativa>? Alternativas { get; set; }
        public virtual ICollection<ProvaQuestao>? ProvasQuestoes { get; set; }
    }
}
