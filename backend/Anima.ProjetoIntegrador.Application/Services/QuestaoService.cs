using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Application.Services.Validators;
using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;
using Microsoft.AspNetCore.Http;

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

        public NovaQuestaoResponse Criar(NovaQuestaoRequest request)
        {
            var response = new NovaQuestaoResponse();
            var notFoundErros = new List<string>();

            var ValidateResult = QuestaoValidate.Validate(request, new QuestaoValidator());

            if (!ValidateResult.IsValid)
            {
                notFoundErros = ValidateErrors.ListErrors(notFoundErros, ValidateResult);
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
                return response;
            }

            var questao = new Questao
            {
                Enunciado = request.Enunciado,
                ProfessorId = Guid.Parse(request.ProfessorId)
            };

            response.Id = _questaoRepository.Criar(questao).ToString();

            return response;
        }
    }
}
