using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class FolhaRespostaRepository : BaseRepository<FolhaResposta>, IFolhaRespostaRepository
    {
        public FolhaRespostaRepository(IntegradorContext context) : base(context)
        {
        }

        public IList<FolhaResposta> ConsultarRespostasPorAvaliacao(Guid? avaliacaoMatriculaId)
        {
            var query = from avaliacaoMatricula in _context.Set<AvaliacaoMatricula>()
                        join folhaResposta in _context.Set<FolhaResposta>()
                            on avaliacaoMatricula.Id equals folhaResposta.AvaliacaoMatriculaId
                        where avaliacaoMatricula.Id == avaliacaoMatriculaId
                        select folhaResposta;

            return query.ToList();
        }

        public void Criar(IEnumerable<FolhaResposta> folhaRespostas)
        {
            AddRange(folhaRespostas);
        }
    }
}
