﻿using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Domain.Interfaces
{
    public interface ITurmaRepository
    {
        IList<AvaliacaoTurmaResponse> ConsultarAvaliacoesPorTurma(Guid idTurma);
        IList<AlunoMatriculaPorTurmaResponse> ConsultarAlunosMatriculadosPorTurma(Guid idTurma);
        IList<TurmaResponse> ConsultarTurmas();
    }
}