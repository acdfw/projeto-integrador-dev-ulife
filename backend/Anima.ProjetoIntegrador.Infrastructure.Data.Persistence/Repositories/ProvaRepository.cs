using Anima.ProjetoIntegrador.Application.Responses;
using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class ProvaRepository : BaseRepository<Prova>, IProvaRepository
    {
        public ProvaRepository(IntegradorContext context) : base(context)
        {
        }
        

        public IList<ProvaResponse> ConsultarQuestoesPorProva(Guid idProva)
        {
            var query = from prova in _context.Set<Prova>()
                        join provaQuestao in _context.Set<ProvaQuestao>()
                            on prova.Id equals provaQuestao.ProvaId
                        join questao in _context.Set<Questao>()
                            on provaQuestao.QuestaoId equals questao.Id
                        where prova.Id == idProva
                        select new ProvaResponse
                        {
                            IdQuestao = questao.Id,
                            Enunciado = questao.Enunciado
                        };

            return query.ToList();
        }
    }
}
