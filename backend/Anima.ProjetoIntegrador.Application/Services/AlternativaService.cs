using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class AlternativaService : IAlternativaService
    {
        private readonly IAlternativaRepository _alternativaRepository;

        public AlternativaService(IAlternativaRepository alternativaRepository)
        {
            _alternativaRepository = alternativaRepository;
        }

        public string Criar(NovaAlternativaRequest request)
        {
            var alternativa = new Alternativa
            {
                Texto = request.Texto,
                AlternativaCorreta = request.AlternativaCorreta
            };

            return _alternativaRepository.Criar(alternativa).ToString();
        }
    }
}
