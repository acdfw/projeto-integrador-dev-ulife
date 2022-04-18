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


        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository, IProvaRepository provaRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
            _provaRepository = provaRepository;
        }

        public AvaliacaoProvaQuestoesAlternativasResponse? ObterProvaTurmaQuestoesPorAvaliacao(Guid id)
        {
            var avaliacaoProva = _avaliacaoRepository.ObterProvaTurmaPorAvaliacao(id);

            if (avaliacaoProva is not null)
            {
                var questoes = _provaRepository.ConsultarQuestoesPorProva(Guid.Parse(avaliacaoProva.ProvaId));

                return new AvaliacaoProvaQuestoesAlternativasResponse
                {
                    NomeProva = avaliacaoProva.NomeProva,
                    NomeAvaliacao = avaliacaoProva.NomeAvaliacao,
                    Questoes = questoes
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
                        
            if (string.IsNullOrEmpty(request.ProvaId))
            {
                notFoundErros.Add("É necessário um professor para criar a avaliação.");
            }

            if (string.IsNullOrEmpty(request.TurmaId))
            {
                notFoundErros.Add("É necessário uma turma para criar a avaliação.");
            }

            if (string.IsNullOrEmpty(request.NomeAvaliacao))
            {
                notFoundErros.Add("É necessário um nome para criar a avaliação.");
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
                ProvaId = Guid.Parse(request.ProvaId),
                TurmaId = Guid.Parse(request.TurmaId),
                Nome = request.NomeAvaliacao
            };

            response.Id = _avaliacaoRepository.Criar(avaliacao).ToString();
            
           
            return response;
        }        
    }
}
