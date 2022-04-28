using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Application.Services.Validators;
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

        private readonly IProvaService _provaService;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository, IProvaService provaService)
        {
            _avaliacaoRepository = avaliacaoRepository;

            _provaService = provaService;
        }

        public AvaliacaoProvaQuestoesAlternativasResponse? ObterProvaTurmaQuestoesPorAvaliacao(Guid id)
        {
            var avaliacaoProva = _avaliacaoRepository.ObterProvaTurmaPorAvaliacao(id);

            if (avaliacaoProva is not null)
            {
                var provaComQuestoes = _provaService.ConsultarQuestoesPorProva(Guid.Parse(avaliacaoProva.ProvaId));

                return new AvaliacaoProvaQuestoesAlternativasResponse
                {
                    NomeProva = avaliacaoProva.NomeProva,
                    NomeAvaliacao = avaliacaoProva.NomeAvaliacao,
                    Questoes = provaComQuestoes.Questoes
                };
            }

            return null;
        }

        public IList<AlunoMatriculadoTurmaResponse> ConsultarTurmaInscritosPorAvaliacao(Guid id)
        {
            return _avaliacaoRepository.ConsultarTurmaInscritosPorAvaliacao(id);
        }

        public NovaAvaliacaoResponse Criar(NovaAvaliacaoRequest request)
        {
            var response = new NovaAvaliacaoResponse();
            var notFoundErros = new List<string>();

            var ValidateResult = AvaliacaoValidate.Validate(request, new AvaliacaoValidator());

            if (!ValidateResult.IsValid)
            {
                notFoundErros = ValidateErrors.ListErrors(notFoundErros ,ValidateResult);
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
                return response;
            }

            var avaliacao = new Avaliacao
            {
                ProvaId = Guid.Parse(request.ProvaId),
                TurmaId = Guid.Parse(request.TurmaId),
                Nome = request.NomeAvaliacao
            };

            response.Id = _avaliacaoRepository.Criar(avaliacao).ToString();
            
           
            return response;
        }        
    }
}
