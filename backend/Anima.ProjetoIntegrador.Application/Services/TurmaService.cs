using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Application.Services.Validators;
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
        private readonly IProfessorRepository _professorRepository;

        public TurmaService(ITurmaRepository turmaRepository, IProfessorRepository professorRepository)
        {
            _turmaRepository = turmaRepository;
            _professorRepository = professorRepository;
        }

        public IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid id)
        {
            return _turmaRepository.ConsultarAvaliacoesPorTurma(id);
        }

        public IList<TurmaAlunoMatriculaResponse> ConsultarInscritosPorTurma(Guid id)
        {
            return _turmaRepository.ConsultarInscritosPorTurma(id);
        }

        public TurmaResponse? ObterTurma(Guid guid)
        {
            return _turmaRepository.ObterPorId(guid);
        }

        public NovaTurmaResponse Criar(NovaTurmaRequest request)
        {   
            var response = new NovaTurmaResponse();
            var notFoundErros = new List<string>();

            var ValidateResult = TurmaValidate.Validate(request, new TurmaValidator());

            if (!ValidateResult.IsValid)
            {
                notFoundErros = ValidateErrors.ListErrors(notFoundErros, ValidateResult);
                response.AddError(StatusCodes.Status404NotFound, notFoundErros);
                return response;
            }

            var professorId = _professorRepository.ObterProfessorPorUsuario(Guid.Parse(request.UsuarioId));
            var turma = new Turma
            {
                Nome = request.Nome,
                ProfessorId = professorId
            };

            response.Id = _turmaRepository.Criar(turma).ToString();

            return response;
        }        
    }
}
