using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Anima.ProjetoIntegrador.Domain.Core.Entities
{
    [ExcludeFromCodeCoverage]
    public class Matricula : Entity
    {
        public Guid AlunoId { get; set; }
        public virtual Aluno? Aluno { get; set; }
        public Guid TurmaId { get; set; }
        public virtual Turma? Turma { get; set; }
        public virtual ICollection<AvaliacaoMatricula>? AvaliacoesMatriculas { get; set; }
    }
}
