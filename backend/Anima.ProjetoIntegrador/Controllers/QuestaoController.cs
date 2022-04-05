using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestaoController : ControllerBase
    {
        private readonly IQuestaoService _questaoService;

        public QuestaoController(IQuestaoService questaoService)
        {
            _questaoService = questaoService;
        }

        [HttpGet("{id}/alternativas")]
        [Authorize(Roles = "professor")]
        public IActionResult ConsultarAlternativasPorQuestao(string id)
        {
            var alternativasQuestao = _questaoService.ConsultarAlternativasPorQuestao(Guid.Parse(id));

            if (alternativasQuestao is not null)
            {
                if (alternativasQuestao.Alternativas.Any()) {
                    return Ok(alternativasQuestao);
                }

                return NotFound("Não existem alternativas cadastradas para a questão.");
            }

            return NotFound("Questao não encontrada.");
        }
    }
}
