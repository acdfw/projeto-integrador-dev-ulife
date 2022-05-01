using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface IAvaliacaoRepository
    {
        AvaliacaoProvaResponse? ObterProvaTurmaPorAvaliacao(Guid id);
        IList<AlunoMatriculadoTurmaResponse> ConsultarTurmaInscritosPorAvaliacao(Guid id);
        Guid Criar(Avaliacao avaliacao);
        TurmaProfessorAlunoResponse ObterProfessorAlunoTurmaDaAvaliacao(Guid id);
    }
}
