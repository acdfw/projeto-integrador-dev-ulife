using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IAlunoReadRepository : IReadRepository
    {
        object ConsultarTurmasProfessoresAvaliacoesPendentes(Guid id);

        object ConsultarTurmasNaoMatriculas(Guid id);

        object ConsultarAvaliacoesAbertasDeUmaTurma(Guid id);
        object ConsultarAvaliacoesRealizadasDeUmaTurma(Guid id);
        object ConsultarAvaliacoesAbertasNasTurmaMatriculadas(Guid id);
        object ConsultarAvaliacoesRealizadasNasTurmaMatriculadas(Guid id);
    }
}
