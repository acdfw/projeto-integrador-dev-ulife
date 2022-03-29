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

        [HttpGet]
        public IActionResult ConsultarAvaliacoesPorTurma(Guid id)
        {
            var avaliacoes = _turmaService.ConsultarAvaliacoesPorTurma(id);

            if (avaliacoes.Any())
            {
                return Ok(avaliacoes);
            }

            return NotFound("Não existem avaliações cadastradas para a turma.");
        }

        [HttpGet]
        public IActionResult ConsultarAlunosMatriculadosPorTurma(Guid id)
        {
            var alunosMatriculados = _turmaService.ConsultarAlunosMatriculadosPorTurma(id);

            if (alunosMatriculados.Any())
            {
                return Ok(alunosMatriculados);
            }

            return NotFound("Não existem alunos matriculados para a turma.");
        }
    }
}
