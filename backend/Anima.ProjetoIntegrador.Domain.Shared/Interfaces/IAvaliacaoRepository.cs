using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IAvaliacaoRepository
    {
        ProvaTurmaResponse? ObterProvaTurmaPorAvaliacao(Guid id);
    }
}
