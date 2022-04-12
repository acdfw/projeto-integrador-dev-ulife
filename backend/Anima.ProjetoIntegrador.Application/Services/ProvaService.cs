using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;
using Microsoft.AspNetCore.Http;

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

        public NovaProvaResponse Criar(NovaProvaRequest request)
        {
            var response = new NovaProvaResponse();
            var notFoundErros = new List<string>();

            if (string.IsNullOrEmpty(request.Nome))
            {
                notFoundErros.Add("É necessário um nome para a prova.");
            }

            if (string.IsNullOrEmpty(request.ProfessorId))
            {
                notFoundErros.Add("É necessário um professor para a prova.");
            }

            if (notFoundErros.Any())
            {
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
            }

            if (response.Errors.Any())
            {
                return response;
            }

            var prova = new Prova
            {
                Nome = request.Nome,
                ProfessorId = Guid.Parse(request.ProfessorId)
            };

            response.Id = _provaRepository.Criar(prova).ToString();

            return response;
        }
    }
}
