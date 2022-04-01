using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvaController : ControllerBase
    {
        private readonly IProvaService _provaService;

        public ProvaController(IProvaService provaService)
        {
            _provaService = provaService;
        }

        [HttpGet("{id}/questoes")]
        public IActionResult ConsultarQuestoesPorProva(string id)
        {
            var questoes = _provaService.ConsultarQuestoesPorProva(Guid.Parse(id));

            if (questoes.Any())
            {
                return Ok(questoes);
            }

            return NotFound("Não existem questões cadastradas para a prova.");
        }
    }    
}
