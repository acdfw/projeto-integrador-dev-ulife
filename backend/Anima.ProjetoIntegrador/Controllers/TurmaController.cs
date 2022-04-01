using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaService _turmaService;

        public TurmaController(ITurmaService turmaService)
        {
            _turmaService = turmaService;
        }

        [HttpGet("{id}/avaliacoes")]
        public IActionResult ConsultarAvaliacoesPorTurma(string id)
        {
            var avaliacoes = _turmaService.ConsultarAvaliacoesPorTurma(Guid.Parse(id));

            if (avaliacoes.Any())
            {
                return Ok(avaliacoes);
            }

            return NotFound("Não existem avaliações cadastradas para a turma.");
        }

        [HttpGet("alunos/{id}")]
        public IActionResult ConsultarAlunosMatriculadosPorTurma(string id)
        {
            var alunosMatriculados = _turmaService.ConsultarAlunosMatriculadosPorTurma(Guid.Parse(id));

            if (alunosMatriculados.Any())
            {
                return Ok(alunosMatriculados);
            }

            return NotFound("Não existem alunos matriculados para a turma.");
        }
    }
}
