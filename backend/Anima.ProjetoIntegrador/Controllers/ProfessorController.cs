using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpGet("{id}/matriculas/turmas")]
        public IActionResult ConsultarTurmasQuantidadeInscritos(string id)
        {
            var turmasQtdInscritos = _professorService.ConsultarTurmasQuantidadeInscritos(Guid.Parse(id));

            if (turmasQtdInscritos.Any())
            {
                return Ok(turmasQtdInscritos);
            }

            return NotFound("Não existem turmas cadastradas com a quantidade de inscritos para o professor.");
        }

        [HttpGet("{id}/turmas/avaliacoes")]
        public IActionResult ConsultarAvaliacoesDasSuasTurmas(string id)
        {
            var avaliacoesTurmas = _professorService.ConsultarAvaliacoesDasSuasTurmas(Guid.Parse(id));

            if (avaliacoesTurmas.Any())
            {
                return Ok(avaliacoesTurmas);
            }

            return NotFound("Não existem avaliações de quaisquer turmas para o professor.");
        }
    }
}
