using Anima.ProjetoIntegrador.Domain.Shared.Entities;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IWriteRepository
    {
        void Add<TEntity>(TEntity entity) where TEntity : Entity;

        void Update<TEntity>(TEntity entity) where TEntity : Entity;

        void Remove<TEntity>(Guid id) where TEntity : Entity;
    }
}
