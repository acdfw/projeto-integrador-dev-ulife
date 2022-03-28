using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class QuestaoRepository : BaseRepository<Questao>, IQuestaoRepository
    {
        public QuestaoRepository(IntegradorContext context) : base(context)
        {
        }
    }
}
