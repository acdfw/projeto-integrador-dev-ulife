using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Domain.Shared.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class QuestaoRepository : BaseRepository<Questao>, IQuestaoRepository
    {
        public QuestaoRepository(IntegradorContext context) : base(context)
        {
        }

        public IList<AlternativaResponse> ConsultarAlternativasPorQuestao(Guid id)
        {
            var query = from questao in _context.Set<Questao>()
                        join alternativa in _context.Set<Alternativa>()
                            on questao.Id equals alternativa.QuestaoId
                        where questao.Id == id
                        select new AlternativaResponse
                        {
                            Id = alternativa.Id.ToString(),
                            Texto = alternativa.Texto,
                        };

            return query.ToList();
        }
    }
}
