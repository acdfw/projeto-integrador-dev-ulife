using Anima.ProjetoIntegrador.Application.Services.Interfaces;
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
    }
}
