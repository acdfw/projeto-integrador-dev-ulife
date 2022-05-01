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
            var response = _provaService.ConsultarQuestoesPorProva(Guid.Parse(id));

            if (response.Errors.Any(e => e.Key == StatusCodes.Status400BadRequest))
            {
                var badRequestErrors = string.Join(" ", response.Errors[StatusCodes.Status400BadRequest]);
                return BadRequest(badRequestErrors);
            }

            if (response.Errors.Any(e => e.Key == StatusCodes.Status404NotFound))
            {
                var notFoundErrors = string.Join(" ", response.Errors[StatusCodes.Status404NotFound]);
                return NotFound(notFoundErrors);
            }

            return Ok(response);
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

            return Created(string.Empty, $"Prova criada: {response.Id}");
        }
    }    
}
