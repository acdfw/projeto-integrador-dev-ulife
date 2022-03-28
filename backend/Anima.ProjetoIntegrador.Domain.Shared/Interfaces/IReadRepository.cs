using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using System.Linq.Expressions;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IReadRepository
    {
        TEntity? GetById<TEntity>(Guid? id) where TEntity : Entity;

        ICollection<TEntity> GetAll<TEntity>() where TEntity : Entity;

        TEntity? GetByFilter<TEntity>(Expression<Func<TEntity, bool>> expression,
            Expression<Func<TEntity, object>> include = null) where TEntity : Entity;
    }
}
