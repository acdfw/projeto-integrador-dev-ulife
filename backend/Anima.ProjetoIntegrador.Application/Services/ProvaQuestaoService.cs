using Anima.ProjetoIntegrador.Application.Services.Interfaces;
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

            if (string.IsNullOrEmpty(request.ProvaId))
            {
                notFoundErros.Add("É necessário uma prova.");
            }

            if (string.IsNullOrEmpty(request.QuestaoId))
            {
                notFoundErros.Add("É necessário uma questão.");
            }

            if (notFoundErros.Any())
            {
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
            }

            if (response.Errors.Any())
            {
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
