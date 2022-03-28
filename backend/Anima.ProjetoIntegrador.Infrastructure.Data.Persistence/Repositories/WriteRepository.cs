using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class WriteRepository : IWriteRepository
    {
        private readonly IntegradorContext _context;

        public WriteRepository(IntegradorContext context)
        {
            _context = context;
        }

        public void Add<TEntity>(TEntity entity) where TEntity : Entity
        {
            _context.Set<TEntity>().Add(entity);

            _context.SaveChanges();
        }

        public void Update<TEntity>(TEntity entity) where TEntity : Entity
        {
            DbSet<TEntity> table = _context.Set<TEntity>();

            table.Update(entity);

            _context.SaveChanges();
        }

        public void Remove<TEntity>(Guid id) where TEntity : Entity
        {
            DbSet<TEntity> table = _context.Set<TEntity>();

            TEntity entity = table.Find(id);

            table.Remove(entity);

            _context.SaveChanges();
        }
    }
}
