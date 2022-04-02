using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services.Interfaces
{
    public interface IAvaliacaoService
    {
        ProvaTurmaQuestoesResponse? ObterProvaTurmaQuestoesPorAvaliacao(Guid id);
    }
}
