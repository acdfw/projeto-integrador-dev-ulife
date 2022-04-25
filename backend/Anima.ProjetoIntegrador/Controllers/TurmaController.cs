using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "professor")]
        public IActionResult ConsultarAvaliacoesPorTurma(string id)
        {
            var avaliacoes = _turmaService.ConsultarAvaliacoesPorTurma(Guid.Parse(id));

            if (avaliacoes.Any())
            {
                return Ok(avaliacoes);
            }

            return NotFound("Não existem avaliações cadastradas para a turma.");
        }

        [HttpGet("{id}/alunos-matriculados")]
        [Authorize(Roles = "professor")]
        public IActionResult ConsultarInscritosPorTurma(string id)
        {
            var avaliacoes = _turmaService.ConsultarInscritosPorTurma(Guid.Parse(id));

            if (avaliacoes.Any())
            {
                return Ok(avaliacoes);
            }

            return NotFound("Não existem alunos matriculados para a turma.");
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "professor")]
        public IActionResult Obter(string id)
        {
            var turma = _turmaService.ObterTurma(Guid.Parse(id));

            if (turma is not null)
            {
                return Ok(turma);
            }

            return NotFound("Turma não encontrada.");
        }

        [HttpPost]
        [Authorize(Roles = "professor")]
        public IActionResult CriarTurma([FromBody] NovaTurmaRequest request)
        {
            var response = _turmaService.Criar(request);

            if (response.Errors.Any(e => e.Key == StatusCodes.Status400BadRequest))
            {
                var badRequestErrors = string.Join(" ", response.Errors[StatusCodes.Status400BadRequest]);
                return BadRequest(badRequestErrors);
            }

            return Created(string.Empty, $"Turma criada: {response.Id}");
        }
    }
}
