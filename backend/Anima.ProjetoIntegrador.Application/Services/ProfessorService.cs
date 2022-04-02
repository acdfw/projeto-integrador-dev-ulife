using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public IList<TurmaInscritoProfessorResponse> ConsultarTurmasQuantidadeInscritos(Guid id)
        {
            return _professorRepository.ConsultarTurmasQuantidadeInscritos(id);
        }

        public IList<AvaliacaoDisponivelTurmaProfessorResponse> ConsultarAvaliacoesDasSuasTurmas(Guid id)
        {
            return _professorRepository.ConsultarAvaliacoesDasSuasTurmas(id);
        }
    }
}
