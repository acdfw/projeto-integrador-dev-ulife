using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.ProjetoIntegrador.Domain.Shared.Interfaces
{
    public interface IProfessorReadRepository
    {
        object ConsultarTurmasQuantidadeInscritos(Guid id);
        object ConsultarAvaliacoesInscritosPorTurma(Guid id, Guid idTurma);
        object ConsultarAvaliacoesDasSuasTurmas(Guid id);
    }
}
