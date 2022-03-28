using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class AlunoReadRepository : ReadRepository, IAlunoReadRepository
    {
        public AlunoReadRepository(AnimaContext context) : base(context)
        {
        }

        public object ConsultarTurmasProfessoresAvaliacoesPendentes(Guid id)
        {
            var query = from aluno in _context.Set<Aluno>()
                        join matricula in _context.Set<Matricula>()
                            on aluno.Id equals matricula.AlunoId
                        join turma in _context.Set<Turma>()
                            on matricula.TurmaId equals turma.Id
                        join professor in _context.Set<Professor>()
                            on turma.ProfessorId equals professor.Id
                        join usuario in _context.Set<Usuario>()
                            on professor.UsuarioId equals usuario.Id
                        where aluno.Id == id
                        select new
                        {
                            NomeTurma = turma.Nome,
                            NomeProfessor = usuario.Nome
                        };

            return query.ToList();
        }

        public object ConsultarAvaliacoesAbertasDeUmaTurma(Guid id)
        {
            throw new NotImplementedException();
        }

        public object ConsultarAvaliacoesAbertasNasTurmaMatriculadas(Guid id)
        {
            throw new NotImplementedException();
        }

        public object ConsultarAvaliacoesRealizadasDeUmaTurma(Guid id)
        {
            throw new NotImplementedException();
        }

        public object ConsultarAvaliacoesRealizadasNasTurmaMatriculadas(Guid id)
        {
            throw new NotImplementedException();
        }

        public object ConsultarTurmasNaoMatriculas(Guid id)
        {
            throw new NotImplementedException();
        }        

        public ICollection<TEntity> GetAll<TEntity>() where TEntity : Entity
        {
            return base.GetAll<TEntity>();
        }

        public TEntity? GetByFilter<TEntity>(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>> include = null) where TEntity : Entity
        {
            return base.GetByFilter(expression, include);
        }

        public TEntity? GetById<TEntity>(Guid? id) where TEntity : Entity
        {
            return base.GetById<TEntity>(id);
        }
    }
}
