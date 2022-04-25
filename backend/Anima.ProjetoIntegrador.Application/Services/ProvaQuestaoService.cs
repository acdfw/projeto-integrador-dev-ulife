using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Application.Services.Validators;
using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;
using Microsoft.AspNetCore.Http;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class ProvaQuestaoService : IProvaQuestaoService
    {
        private readonly IProvaQuestaoRepository _provaQuestaoRepository;

        public ProvaQuestaoService(IProvaQuestaoRepository provaQuestaoRepository)
        {
            _provaQuestaoRepository = provaQuestaoRepository;
        }

        public NovaProvaQuestaoResponse Criar(NovaProvaQuestaoRequest request)
        {
            var response = new NovaProvaQuestaoResponse();
            var notFoundErros = new List<string>();

            var ValidateResult = ProvaQuestaoValidate.Validate(request, new ProvaQuestaoValidator());

            if (!ValidateResult.IsValid)
            {
                notFoundErros = ValidateErrors.ListErrors(notFoundErros, ValidateResult);
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
                return response;
            }

            var provaQuestao = new ProvaQuestao
            {
                ProvaId = Guid.Parse(request.ProvaId),
                QuestaoId = Guid.Parse(request.QuestaoId)
            };

            response.Id = _provaQuestaoRepository.Criar(provaQuestao).ToString();

            return response;
        }
    }
}
