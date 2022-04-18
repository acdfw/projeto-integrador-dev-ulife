using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class ProvaQuestaoRepository : BaseRepository<ProvaQuestao>, IProvaQuestaoRepository
    {
        public ProvaQuestaoRepository(IntegradorContext context) : base(context)
        {
        }

        public Guid Criar(ProvaQuestao provaQuestao)
        {
            return Add(provaQuestao).Id;
        }
    }
}
