using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacaoMatriculaController : ControllerBase
    {
        private readonly IAvaliacaoMatriculaService _avaliacaoMatriculaService;

        public AvaliacaoMatriculaController(IAvaliacaoMatriculaService avaliacaoMatriculaService)
        {
            _avaliacaoMatriculaService = avaliacaoMatriculaService;
        }

        [HttpGet("{id}/folha-resposta-aluno")]
        [Authorize(Roles = "professor,aluno")]
        public IActionResult ConsultarAvaliacaoRealizadaDoAluno(string id)
        {
            var response = _avaliacaoMatriculaService.ConsultarRespostasDoAlunoPorAvaliacao(Guid.Parse(id));

            if (response is not null)
            {
                return Ok(response);
            }

            return NotFound("Este aluno não iniciou a avaliação.");
        }

        [HttpPost]
        [Authorize(Roles = "aluno")]
        public IActionResult ResponderAvaliacao([FromBody] AvaliacaoMatriculaRequest request)
        {
            var response = _avaliacaoMatriculaService.ResponderAvaliacao(request);

            if (response.Errors.Any(e => e.Key == StatusCodes.Status400BadRequest))
            {
                var badRequestErros = string.Join(" ", response.Errors[StatusCodes.Status400BadRequest]);
                return BadRequest(badRequestErros);
            }

            return Created(string.Empty, $"Avaliação respondida: {response.Id}");
        }
    }
}
