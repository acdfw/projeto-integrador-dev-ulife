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
        private readonly IAlternativaRepository _alternativaRepository;
        private readonly IProfessorRepository _professorRepository;

        public QuestaoService(IQuestaoRepository questaoRepository, IAlternativaRepository alternativaRepository,
            IProfessorRepository professorRepository)
        {
            _questaoRepository = questaoRepository;
            _alternativaRepository = alternativaRepository;
            _professorRepository = professorRepository;
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
            var badRequestErros = new List<string>();

            var ValidateResult = QuestaoValidate.Validate(request, new QuestaoValidator());

            if (!ValidateResult.IsValid)
            {
                badRequestErros = ValidateErrors.ListErrors(badRequestErros, ValidateResult);
                response.AddError(StatusCodes.Status400BadRequest, badRequestErros);
                return response;
            }

            var professorId = _professorRepository.ObterProfessorPorUsuario(Guid.Parse(request.UsuarioId));

            var questao = new Questao
            {
                Enunciado = request.Enunciado,
                Nome = request.Nome,
                ProfessorId = professorId
            };

            var questaoId = _questaoRepository.Criar(questao);

            var alternativas = request.Alternativas.Select(a => new Alternativa
            {
                QuestaoId = questaoId,
                Texto = a.Texto,
                AlternativaCorreta = a.AlternativaCorreta
            });

            _alternativaRepository.Criar(alternativas);

            response.Id = questaoId.ToString();

            return response;
        }
    }
}
