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

        public NovaAvaliacaoResponse Criar(NovaAvaliacaoRequest request)
        {
            var response = new NovaAvaliacaoResponse();
            var notFoundErros = new List<string>();

            if (string.IsNullOrEmpty(request.ProvaId))
            {
                notFoundErros.Add("É necessário uma prova para criar a avaliação.");
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
                ProvaId = Guid.Parse(request.ProvaId)
            };

            response.Id = _avaliacaoRepository.Criar(avaliacao).ToString();

            return response;
        }
    }
}
