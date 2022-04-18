using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("{id}/prova/questoes")]
        [Authorize(Roles = "professor")]
        public IActionResult ObterProvaTurmaQuestoesPorAvaliacao(string id)
        {
            var provaTurmaComQuestoes = _avaliacaoService.ObterProvaTurmaQuestoesPorAvaliacao(Guid.Parse(id));

            if (provaTurmaComQuestoes is not null)
            {
                return Ok(provaTurmaComQuestoes);
            }

            return NotFound("Avaliação não encontrada.");
        }

        [HttpGet("{id}/avaliacao/turma/alunos-matriculados-notas")]
        [Authorize(Roles = "professor")]
        public IActionResult ConsultarTurmaInscritosPorAvaliacao(string id)
        {
            var alunosMatriculados = _avaliacaoService.ConsultarTurmaInscritosPorAvaliacao(Guid.Parse(id));

            if (alunosMatriculados.Any())
            {
                return Ok(alunosMatriculados);
            }

            return NotFound("Não existem alunos matriculados para a turma.");
        }

        [HttpPost]
        [Authorize(Roles = "professor")]
        public IActionResult Criar([FromBody] NovaAvaliacaoRequest request)
        {
            var response = _avaliacaoService.Criar(request);

            if (response.Errors.Any(e => e.Key == StatusCodes.Status404NotFound))
            {
                var notFoundErrors = string.Join(" ", response.Errors[StatusCodes.Status404NotFound]);
                return NotFound(notFoundErrors);
            }

            return Created(string.Empty, $"Avaliação criada: {response.Id}");
        }
    }
}
