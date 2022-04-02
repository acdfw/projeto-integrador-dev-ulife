using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class BaseRepository<TEntity> where TEntity : Entity
    {
        protected readonly IntegradorContext _context;

        public BaseRepository(IntegradorContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();

            return entity;
        } 

        public IQueryable<TEntity> GetQueryable()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public TEntity? GetById(Guid id)
        {
            return _context.Set<TEntity>().FirstOrDefault(t => t.Id == id);
        }
    }
}
