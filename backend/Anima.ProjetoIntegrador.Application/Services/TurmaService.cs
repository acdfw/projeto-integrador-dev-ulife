using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;
using Microsoft.AspNetCore.Http;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaService(ITurmaRepository turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }

        public IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid id)
        {
            return _turmaRepository.ConsultarAvaliacoesPorTurma(id);
        }

        public IList<AlunoMatriculaPorTurmaResponse> ConsultarAlunosMatriculadosPorTurma(Guid id)
        {
            return _turmaRepository.ConsultarAlunosMatriculadosPorTurma(id);
        }

        public NovaTurmaResponse Criar(NovaTurmaRequest request)
        {
            var response = new NovaTurmaResponse();
            var notFoundErros = new List<string>();

            if (string.IsNullOrEmpty(request.Nome))
            {
                notFoundErros.Add("É necessário um nome para criar a turma.");
            }

            if (string.IsNullOrEmpty(request.ProfessorId))
            {
                notFoundErros.Add("É necessário um professor para criar a turma.");
            }

            if (notFoundErros.Any())
            {
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
            }

            if (response.Errors.Any())
            {
                return response;
            }

            var turma = new Turma
            {
                Nome = request.Nome,
                ProfessorId = Guid.Parse(request.ProfessorId)
            };

            response.Id = _turmaRepository.Criar(turma).ToString();

            return response;
        }
    }
}
