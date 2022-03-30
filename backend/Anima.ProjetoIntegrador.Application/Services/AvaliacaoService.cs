using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly IProvaRepository _provaRepository;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository, IProvaRepository provaRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
            _provaRepository = provaRepository;
        }

        public ProvaTurmaQuestoesResponse? ObterProvaTurmaQuestoesPorAvaliacao(Guid id)
        {
            var provaTurma = _avaliacaoRepository.ObterProvaTurmaPorAvaliacao(id);

            if (provaTurma is not null)
            {
                var questoes = _provaRepository.ConsultarQuestoesPorProva(Guid.Parse(provaTurma.IdentificadorProva));

                return new ProvaTurmaQuestoesResponse
                {
                    IdentificadorProva = provaTurma.IdentificadorProva,
                    NomeTurma = provaTurma.NomeTurma,
                    Questoes = questoes
                };
            }

            return null;
        }
    }
}
