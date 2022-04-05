using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("{id}/turma/{idTurma}/avaliacoes")]
        [Authorize(Roles = "aluno")]
        public IActionResult ConsultarAvaliacoesDeUmaTurmaMatriculada(string id, string idTurma)
        {
            var avaliacoes = _alunoService.ConsultarAvaliacoesDeUmaTurmaMatriculada(Guid.Parse(id), Guid.Parse(idTurma));

            if (avaliacoes.Any())
            {
                return Ok(avaliacoes);
            }

            return NotFound("Não existem avaliações pendentes ou realizadas do aluno para a turma");
        }

        [HttpGet("{id}/turma/avaliacoes")]
        [Authorize(Roles = "aluno")]
        public IActionResult ConsultarAvaliacoesTurmasMatriculadas(string id)
        {
            var avaliacoes = _alunoService.ConsultarAvaliacoesTurmasMatriculadas(Guid.Parse(id));

            if (avaliacoes.Any())
            {
                return Ok(avaliacoes);
            }

            return NotFound("Não existem avaliações pendentes ou realizadas das turmas em que este aluno está matriculado.");
        }

        [HttpGet("{id}/todas-turmas")]
        [Authorize(Roles = "aluno")]
        public IActionResult ConsultarTurmasMatriculadasOuNaoDoAluno(string id)
        {
            var turmas = _alunoService.ConsultarTurmasMatriculadasOuNaoDoAluno(Guid.Parse(id));

            if (turmas.Any())
            {
                return Ok(turmas);
            }

            return NotFound("Não existem quaisquer turmas no qual o aluno esteja matriculado ou não.");
        }
    }
}
