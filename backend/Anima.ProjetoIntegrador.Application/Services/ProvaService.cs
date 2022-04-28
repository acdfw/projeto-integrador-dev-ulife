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
        private readonly IProvaQuestaoRepository _provaQuestaoRepository;
        private readonly IAlternativaRepository _alternativaRepository;
        private readonly IProfessorRepository _professorRepository;

        public ProvaService(IProvaRepository provaRepository, IProvaQuestaoRepository provaQuestaoRepository, 
            IAlternativaRepository alternativaRepository, IProfessorRepository professorRepository)
        {
            _provaRepository = provaRepository;
            _alternativaRepository = alternativaRepository;
            _provaQuestaoRepository = provaQuestaoRepository;
            _professorRepository = professorRepository;
        }

        public ProvaResponse ConsultarQuestoesPorProva(Guid id)
        {
            var errosBadRequest = new List<string>();
            var errosNotFound = new List<string>();
            var provaResponse = new ProvaResponse();
            var prova = _provaRepository.ObterPorId(id);

            if(prova is not null)
            {
                provaResponse.Nome = prova.Nome;
            } 
            else
            {
                errosBadRequest.Add("Prova não encontrada!");
            }

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

                provaResponse.Questoes = questoes;
            } 
            else
            {
                errosNotFound.Add("Não foram encontradas questões para esta prova!");
            }

            if (errosBadRequest.Any())
            {
                provaResponse.AddError(StatusCodes.Status400BadRequest, errosBadRequest);
            }

            if (errosNotFound.Any())
            {
                provaResponse.AddError(StatusCodes.Status404NotFound, errosNotFound);
            }

            return provaResponse;
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

            var professorId = _professorRepository.ObterProfessorPorUsuario(Guid.Parse(request.UsuarioId));
            var prova = new Prova
            {
                Nome = request.Nome,
                ProfessorId = professorId
            };

            var provaQuestao = new List<ProvaQuestao>();            

            response.Id = _provaRepository.Criar(prova).ToString();

            foreach (var id in request.QuestoesId)
            {
                provaQuestao.Add(new ProvaQuestao
                {
                    ProvaId = Guid.Parse(response.Id),
                    QuestaoId = Guid.Parse(id)
                });
            }

            _provaQuestaoRepository.Criar(provaQuestao);

            return response;
        }
    }
}
