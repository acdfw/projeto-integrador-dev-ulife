using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Auth.TokenGenerator;
using Microsoft.AspNetCore.Http;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly ITokenService _tokenService;

        public LoginService(IUsuarioRepository usuarioRepository, ITokenService tokenService)
        {
            _usuarioRepository = usuarioRepository;

            _tokenService = tokenService;
        }

        public LoginUsuarioResponse? Logar(LoginUsuarioRequest request)
        {
            var response = new LoginUsuarioResponse();
            var usuario = _usuarioRepository.ObterPorLoginSenha(request.Login, request.Senha);

            if (usuario is null)
            {
                response.AddError(StatusCodes.Status401Unauthorized, "Usuário ou senha inválidos!");
                return response;
            }

            var token = _tokenService.GenerateToken(usuario);

            response.Usuario = usuario;
            response.Token = token;

            return response;
        }
    }
}
