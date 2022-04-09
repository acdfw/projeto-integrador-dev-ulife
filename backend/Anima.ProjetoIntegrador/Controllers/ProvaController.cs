using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "professor")]
        public IActionResult ConsultarQuestoesPorProva(string id)
        {
            var questoes = _provaService.ConsultarQuestoesPorProva(Guid.Parse(id));

            if (questoes.Any())
            {
                return Ok(questoes);
            }

            return NotFound("Não existem questões cadastradas para a prova.");
        }

        [HttpPost]
        [Authorize(Roles = "professor")]
        public IActionResult CriarProva([FromBody] NovaProvaRequest request)
        {
            var response = _provaService.Criar(request);

            if (response.Errors.Any(e => e.Key == StatusCodes.Status404NotFound))
            {
                var notFoundErrors = string.Join(" ", response.Errors[StatusCodes.Status404NotFound]);
                return NotFound(notFoundErrors);
            }

            return Created(string.Empty, $"Alternativa criada: {response.Id}");
        }
    }    
}
