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

        [HttpPost]
        [Authorize(Roles = "professor")]
        public IActionResult CriarTurma([FromBody] NovaTurmaRequest request)
        {
            var response = _turmaService.Criar(request);

            if (response.Errors.Any(e => e.Key == StatusCodes.Status404NotFound))
            {
                var notFoundErrors = string.Join(" ", response.Errors[StatusCodes.Status404NotFound]);
                return NotFound(notFoundErrors);
            }

            return Created(string.Empty, $"Turma criada: {response.Id}");
        }
    }
}
