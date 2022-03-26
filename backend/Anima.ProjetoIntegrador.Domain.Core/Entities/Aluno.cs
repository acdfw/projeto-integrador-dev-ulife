using Anima.ProjetoIntegrador.Domain.Shared.Entities;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    public class Aluno : Entity
    {
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
}
