using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Logar([FromBody] LoginUsuarioRequest request)
        {
            var response = _loginService.Logar(request);

            if(response.Errors.Any(e => e.Key == StatusCodes.Status401Unauthorized))
            {
                return Unauthorized("Usuário ou senha inválidos!");
            }            

            return Ok(response);
        }
    }
}
