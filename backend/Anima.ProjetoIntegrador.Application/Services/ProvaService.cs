using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Application.Services.Validators;
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
        private readonly IAlternativaRepository _alternativaRepository;

        public ProvaService(IProvaRepository provaRepository, IAlternativaRepository alternativaRepository)
        {
            _provaRepository = provaRepository;
            _alternativaRepository = alternativaRepository;
        }

        public IList<QuestaoResponse> ConsultarQuestoesPorProva(Guid id)
        {
            var questoes = _provaRepository.ConsultarQuestoesPorProva(id);

            if (questoes.Any())
            {
                var questoesId = questoes.Select(x => Guid.Parse(x.Id));
                var alternativas = _alternativaRepository.ConsultarPorQuestoes(questoesId);

                if (alternativas.Any())
                {
                    var alternativasAgrupadas = alternativas.GroupBy(x => x.QuestaoId).ToDictionary(x => x.Key, x => x.ToList());

                    foreach (var questao in questoes)
                    {
                        questao.Alternativas = alternativasAgrupadas[questao.Id];
                    }
                }
            }            

            return questoes;
        }

        public NovaProvaResponse Criar(NovaProvaRequest request)
        {
            var response = new NovaProvaResponse();
            var notFoundErros = new List<string>();

            var ValidateResult = ProvaValidate.Validate(request, new ProvaValidator());

            if (!ValidateResult.IsValid)
            {
                notFoundErros = ValidateErrors.ListErrors(notFoundErros, ValidateResult);
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
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
