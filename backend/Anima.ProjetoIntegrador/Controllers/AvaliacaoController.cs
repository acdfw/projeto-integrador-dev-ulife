using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly IAvaliacaoService _avaliacaoService;

        public AvaliacaoController(IAvaliacaoService avaliacaoService)
        {
            _avaliacaoService = avaliacaoService;
        }

        [HttpGet("turma/{id}/prova/questoes")]
        [Authorize(Roles = "professor")]
        public IActionResult ObterProvaTurmaQuestoesPorAvaliacao(string id)
        {
            var provaTurmaComQuestoes = _avaliacaoService.ObterProvaTurmaQuestoesPorAvaliacao(Guid.Parse(id));

            if (provaTurmaComQuestoes is not null)
            {
                return Ok(provaTurmaComQuestoes);
            }

            return NotFound("Avaliação não encontrada.");
        }
    }
}
