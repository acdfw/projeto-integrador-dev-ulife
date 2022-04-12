using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlternativaController : ControllerBase
    {
        private readonly IAlternativaService _alternativaService;

        public AlternativaController(IAlternativaService alternativaService)
        {
            _alternativaService = alternativaService;
        }

        [HttpPost]
        [Authorize(Roles = "professor")]
        public IActionResult CriarAlternativa([FromBody] NovaAlternativaRequest request)
        {
            var response = _alternativaService.Criar(request);

            if (response.Errors.Any(e => e.Key == StatusCodes.Status404NotFound))
            {
                var notFoundErrors = string.Join(" ", response.Errors[StatusCodes.Status404NotFound]);
                return NotFound(notFoundErrors);
            }

            return Created(string.Empty, $"Alternativa criada: {response.Id}");
        }
    }
}
