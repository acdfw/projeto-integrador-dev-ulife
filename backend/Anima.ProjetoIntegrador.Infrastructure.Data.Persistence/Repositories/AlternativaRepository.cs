using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class AlternativaRepository : BaseRepository<Alternativa>, IAlternativaRepository
    {
        public AlternativaRepository(IntegradorContext context) : base(context)
        {
        }

        public Guid Criar(Alternativa alternativa)
        {
            return Add(alternativa).Id;
        }

        public Guid Alterar(Alternativa alternativa)
        {
            return Update(alternativa).Id;
        }
    }
}
