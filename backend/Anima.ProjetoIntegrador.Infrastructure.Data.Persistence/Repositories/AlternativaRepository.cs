using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;
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

        public IList<AlternativaResponse> ConsultarPorQuestoes(IEnumerable<Guid> questoesId)
        {
            var query = from alternativa in _context.Set<Alternativa>()
                        join questao in _context.Set<Questao>()
                            on alternativa.QuestaoId equals questao.Id
                        where questoesId.Contains(questao.Id)
                        select new AlternativaResponse
                        {
                            Id = alternativa.Id.ToString(),
                            Texto = alternativa.Texto,
                            QuestaoId = questao.Id.ToString()
                        };

            return query.ToList();
        }
    }
}
