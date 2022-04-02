using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class QuestaoService : IQuestaoService
    {
        private readonly IQuestaoRepository _questaoRepository;

        public QuestaoService(IQuestaoRepository questaoRepository)
        {
            _questaoRepository = questaoRepository;
        }

        public QuestaoAlternativaResponse? ConsultarAlternativasPorQuestao(Guid id)
        {
            var questao = _questaoRepository.ObterPorId(id);

            if(questao is not null)
            {
                var alternativas = _questaoRepository.ConsultarAlternativasPorQuestao(id);

                return new QuestaoAlternativaResponse
                {
                    IdQuestao = questao?.Id,
                    Enunciado = questao?.Enunciado,
                    Alternativas = alternativas
                };
            }

            return null;
        }
    }
}
