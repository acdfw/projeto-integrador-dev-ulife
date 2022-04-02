using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class ProvaService : IProvaService
    {
        private readonly IProvaRepository _provaRepository;

        public ProvaService(IProvaRepository provaRepository)
        {
            _provaRepository = provaRepository;
        }

        public IList<QuestaoResponse> ConsultarQuestoesPorProva(Guid id)
        {
            return _provaRepository.ConsultarQuestoesPorProva(id);
        }

        public void Inserir()
        {

        }
    }
}
