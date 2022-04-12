using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;
using Microsoft.AspNetCore.Http;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class AlternativaService : IAlternativaService
    {
        private readonly IAlternativaRepository _alternativaRepository;

        public AlternativaService(IAlternativaRepository alternativaRepository)
        {
            _alternativaRepository = alternativaRepository;
        }

        public NovaAlternativaResponse Criar(NovaAlternativaRequest request)
        {
            var response = new NovaAlternativaResponse();
            var notFoundErros = new List<string>();

            if (string.IsNullOrEmpty(request.Texto))
            {
                notFoundErros.Add("É necessário um texto para a alternativa.");
            }

            if (string.IsNullOrEmpty(request.QuestaoId))
            { 
                notFoundErros.Add("É necessário uma questão para a alternativa.");
            }

            if (notFoundErros.Any())
            {
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
            }

            if (response.Errors.Any())
            {
                return response;
            }

            var alternativa = new Alternativa
            {
                QuestaoId = Guid.Parse(request.QuestaoId),
                Texto = request.Texto,
                AlternativaCorreta = request.AlternativaCorreta
            };

            response.Id = _alternativaRepository.Criar(alternativa).ToString();

            return response;
        }
    }
}
