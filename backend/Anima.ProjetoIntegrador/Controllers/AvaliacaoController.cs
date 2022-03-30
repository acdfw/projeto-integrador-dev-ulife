using Anima.ProjetoIntegrador.Application.Services.Interfaces;
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

        [HttpGet]
        public IActionResult ObterProvaTurmaQuestoesPorAvaliacao(Guid id)
        {
            var provaTurmaComQuestoes = _avaliacaoService.ObterProvaTurmaQuestoesPorAvaliacao(id);

            if (provaTurmaComQuestoes is not null)
            {
                return Ok(provaTurmaComQuestoes);
            }

            return NotFound("Avaliação não encontrada.");
        }
    }
}
