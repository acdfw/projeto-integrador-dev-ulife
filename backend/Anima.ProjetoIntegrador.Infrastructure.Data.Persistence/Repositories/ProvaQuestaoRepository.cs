using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class ProvaQuestaoRepository : BaseRepository<ProvaQuestao>, IProvaQuestaoRepository
    {
        public ProvaQuestaoRepository(IntegradorContext context) : base(context)
        {
        }

        public IList<ProvaQuestaoResponse> ConsultarProvaQuestaoDoProfessor(Guid idProfessor)
        {
            var query = from professor in _context.Set<Professor>()
                        join prova in _context.Set<Prova>()
                            on professor.Id equals prova.ProfessorId
                        join provaQuestao in _context.Set<ProvaQuestao>()
                            on prova.Id equals provaQuestao.ProvaId
                        where professor.UsuarioId == idProfessor
                        select new ProvaQuestaoResponse
                        {
                            IdProva = prova.Id.ToString(),
                            IdProvaQuestao = provaQuestao.Id.ToString()
                        };

            return query.ToList();
        }

        public Guid Criar(ProvaQuestao provaQuestao)
        {
            return Add(provaQuestao).Id;
        }
    }
}
