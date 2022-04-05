using Anima.ProjetoIntegrador.Domain.Entities;

namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class LoginUsuarioResponse : BaseResponse
    {
        public Usuario? Usuario { get; set; }
        public string? Token { get; set; }
    }
}
