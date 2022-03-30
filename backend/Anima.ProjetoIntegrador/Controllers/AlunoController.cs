using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public IActionResult ConsultarAvaliacoesDeUmaTurmaMatriculada(Guid id, Guid idTurma)
        {
            var avaliacoes = _alunoService.ConsultarAvaliacoesDeUmaTurmaMatriculada(id, idTurma);

            if (avaliacoes.Any())
            {
                return Ok(avaliacoes);
            }

            return NotFound("Não existem avaliações pendentes ou realizadas do aluno para a turma");
        }

        [HttpGet]
        public IActionResult ConsultarAvaliacoesTurmasMatriculadas(Guid id)
        {
            var avaliacoes = _alunoService.ConsultarAvaliacoesTurmasMatriculadas(id);

            if (avaliacoes.Any())
            {
                return Ok(avaliacoes);
            }

            return NotFound("Não existem avaliações pendentes ou realizadas das turmas em que este aluno está matriculado.");
        }

        [HttpGet]
        public IActionResult ConsultarTurmasMatriculadasOuNaoDoAluno(Guid id)
        {
            var turmas = _alunoService.ConsultarTurmasMatriculadasOuNaoDoAluno(id);

            if (turmas.Any())
            {
                return Ok(turmas);
            }

            return NotFound("Não existem quaisquer turmas no qual o aluno esteja matriculado ou não.");
        }
    }
}
