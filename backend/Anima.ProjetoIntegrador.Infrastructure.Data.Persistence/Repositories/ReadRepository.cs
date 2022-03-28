using Anima.ProjetoIntegrador.Domain.Shared.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class ReadRepository : IReadRepository
    {
        protected readonly IntegradorContext _context;

        public ReadRepository(IntegradorContext context)
        {
            _context = context;
        }

        public TEntity? GetById<TEntity>(Guid? id) where TEntity : Entity
        {
            return _context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public ICollection<TEntity> GetAll<TEntity>() where TEntity : Entity
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity? GetByFilter<TEntity>(Expression<Func<TEntity, bool>> expression,
            Expression<Func<TEntity, object>> include = null) where TEntity : Entity
        {
            return _context.Set<TEntity>().Where(expression).Include(include).FirstOrDefault();
        }
    }
}
