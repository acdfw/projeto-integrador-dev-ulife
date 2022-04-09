using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;
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

        public QuestaoResponse? ObterPorId(Guid id)
        {
            var questao = GetById(id);

            return new QuestaoResponse
            {
                Id = questao?.Id.ToString(),
                Enunciado = questao?.Enunciado,
            };
        }

        public Guid Criar(Questao questao)
        {
            return Add(questao).Id;
        }
    }
}
