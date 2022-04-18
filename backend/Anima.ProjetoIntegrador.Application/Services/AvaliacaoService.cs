using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;
using Microsoft.AspNetCore.Http;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly IProvaRepository _provaRepository;

        private readonly IProvaService _provaService;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository, IProvaRepository provaRepository,
            IProvaService provaService)
        {
            _avaliacaoRepository = avaliacaoRepository;
            _provaRepository = provaRepository;

            _provaService = provaService;
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

        public IList<AlunoMatriculadoTurmaResponse> ConsultarTurmaInscritosPorAvaliacao(Guid id)
        {
            return _avaliacaoRepository.ConsultarTurmaInscritosPorAvaliacao(id);
        }

        public NovaAvaliacaoResponse CriarComProva(NovaAvaliacaoRequest request)
        {
            var response = new NovaAvaliacaoResponse();
            var notFoundErros = new List<string>();

            var novaProvaRequest = new NovaProvaRequest
            {
                Nome = request.NomeProva,
                ProfessorId = request.ProfessorId
            };
            var novaProvaResponse = _provaService.Criar(novaProvaRequest);

            if (novaProvaResponse.IsSuccess)
            {
                if (string.IsNullOrEmpty(request.ProfessorId))
                {
                    notFoundErros.Add("É necessário um professor para criar a avaliação.");
                }

                if (string.IsNullOrEmpty(request.TurmaId))
                {
                    notFoundErros.Add("É necessário uma turma para criar a avaliação.");
                }

                if (notFoundErros.Any())
                {
                    response.AddError(StatusCodes.Status404NotFound, notFoundErros);
                }

                if (response.Errors.Any())
                {
                    return response;
                }

                var avaliacao = new Avaliacao
                {
                    TurmaId = Guid.Parse(request.TurmaId),
                    ProvaId = Guid.Parse(novaProvaResponse.Id)
                };

                response.Id = _avaliacaoRepository.Criar(avaliacao).ToString();
            }
           
            return response;
        }        
    }
}
