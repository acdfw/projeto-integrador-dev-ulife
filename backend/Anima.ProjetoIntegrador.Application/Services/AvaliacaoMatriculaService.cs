using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Interfaces;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class AvaliacaoMatriculaService : IAvaliacaoMatriculaService
    {
        private readonly IAvaliacaoMatriculaRepository _avaliacaoMatriculaRepository;
        private readonly IFolhaRespostaRepository _folhaRespostaRepository;
        private readonly IAvaliacaoRepository _avaliacaoRepository;

        private readonly IAvaliacaoService _avaliacaoService;

        public AvaliacaoMatriculaService(IAvaliacaoMatriculaRepository avaliacaoMatriculaRepository,
            IFolhaRespostaRepository folhaRespostaRepository, IAvaliacaoRepository avaliacaoRepository, IAvaliacaoService avaliacaoService)
        {
            _avaliacaoMatriculaRepository = avaliacaoMatriculaRepository;
            _folhaRespostaRepository = folhaRespostaRepository;
            _avaliacaoRepository = avaliacaoRepository;

            _avaliacaoService = avaliacaoService;
        }

        public object ConsultarRespostasDoAlunoPorAvaliacao(Guid avaliacaoMatriculaId)
        {
            var avaliacaoMatricula = _avaliacaoMatriculaRepository.ObterPorId(avaliacaoMatriculaId);
            var provaComQuestoes = _avaliacaoService.ObterProvaTurmaQuestoesPorAvaliacao(avaliacaoMatricula.AvaliacaoId.Value);
            var folhaRespostas = _folhaRespostaRepository.ConsultarRespostasPorAvaliacao(avaliacaoMatriculaId);
            var nomeTurmaProfessorAluno = _avaliacaoRepository.ObterProfessorAlunoTurmaDaAvaliacao(avaliacaoMatricula.AvaliacaoId.Value);
            var folhaRespostasAgrupada = folhaRespostas.GroupBy(f => (f.AvaliacaoMatriculaId, f.QuestaoId)).ToDictionary(f => f.Key, f => f.SingleOrDefault());

            foreach (var questao in provaComQuestoes.Questoes)
            {
                questao.AlternativaCorretaId = questao.Alternativas.SingleOrDefault(a => a.AlternativaCorreta == true).Id;                 
                questao.AlternativaRespondidaId = folhaRespostasAgrupada.SingleOrDefault(f => f.Key.AvaliacaoMatriculaId.Value == avaliacaoMatriculaId 
                                                    && f.Key.QuestaoId == Guid.Parse(questao.Id)).Value.AlternativaId.ToString();
            }

            return new
            {
                NomeTurma = nomeTurmaProfessorAluno.NomeTurma,
                NomeProfessor = nomeTurmaProfessorAluno.NomeProfessor,
                NomeAluno = nomeTurmaProfessorAluno.NomeAluno,
                ProvaComQuestoes = provaComQuestoes
            };
        }
    }
}
