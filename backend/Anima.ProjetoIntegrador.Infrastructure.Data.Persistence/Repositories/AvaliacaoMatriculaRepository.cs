using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class AvaliacaoMatriculaRepository : BaseRepository<AvaliacaoMatricula>, IAvaliacaoMatriculaRepository
    {
        public AvaliacaoMatriculaRepository(IntegradorContext context) : base(context)
        {
        }
    }
}
