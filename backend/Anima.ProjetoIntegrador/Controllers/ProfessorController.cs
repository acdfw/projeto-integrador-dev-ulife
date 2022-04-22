using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "professor")]
        [HttpGet("{id}/turmas-inscritos-avaliacoes")]
        public IActionResult ConsultarTurmasQuantidadeInscritosAvaliacoes(string id)
        {
            var turmasQtdInscritos = _professorService.ConsultarTurmasQuantidadeInscritosAvaliacoes(Guid.Parse(id));

            if (turmasQtdInscritos.Any())
            {
                return Ok(turmasQtdInscritos);
            }

            return NotFound("Não existem turmas cadastradas com a quantidade de inscritos e avaliações para o professor.");
        }

        [HttpGet("{id}/turmas/avaliacoes")]
        [Authorize(Roles = "professor")]
        public IActionResult ConsultarAvaliacoesDasSuasTurmas(string id)
        {
            var avaliacoesTurmas = _professorService.ConsultarAvaliacoesDasSuasTurmas(Guid.Parse(id));

            if (avaliacoesTurmas.Any())
            {
                return Ok(avaliacoesTurmas);
            }

            return NotFound("Não existem avaliações de quaisquer turmas para o professor.");
        }

        [HttpGet("{id}/provas")]
        [Authorize(Roles = "professor")]
        public IActionResult ConsultarProvasDoProfessor(string id)
        {
            var provas = _professorService.ConsultarProvasDoProfessor(Guid.Parse(id));

            if (provas.Any())
            {
                return Ok(provas);
            }

            return NotFound("Não existem questionários para o professor.");
        }
    }
}
