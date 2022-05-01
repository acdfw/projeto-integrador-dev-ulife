using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Entities;
using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Domain.Requests;
using Anima.ProjetoIntegrador.Domain.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class AvaliacaoMatriculaService : IAvaliacaoMatriculaService
    {
        private readonly IAvaliacaoMatriculaRepository _avaliacaoMatriculaRepository;
        private readonly IFolhaRespostaRepository _folhaRespostaRepository;
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly IMatriculaRepository _matriculaRepository;

        private readonly IProvaService _provaService;
        private readonly IAvaliacaoService _avaliacaoService;

        public AvaliacaoMatriculaService(IAvaliacaoMatriculaRepository avaliacaoMatriculaRepository,
            IFolhaRespostaRepository folhaRespostaRepository, IAvaliacaoRepository avaliacaoRepository,
            IMatriculaRepository matriculaRepository,
            IProvaService provaService, IAvaliacaoService avaliacaoService)
        {
            _avaliacaoMatriculaRepository = avaliacaoMatriculaRepository;
            _folhaRespostaRepository = folhaRespostaRepository;
            _avaliacaoRepository = avaliacaoRepository;
            _matriculaRepository = matriculaRepository;

            _provaService = provaService;
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

        public AvaliacaoMatriculaResponse ResponderAvaliacao(AvaliacaoMatriculaRequest request)
        {
            var response = new AvaliacaoMatriculaResponse();
            var provaId = _avaliacaoRepository.ObterPorId(Guid.Parse(request.AvaliacaoId)).ProvaId;
            var provaComQuestoes = _provaService.ConsultarQuestoesPorProva(provaId.Value);
            var questoesAcertadas = 0.0;

            foreach (var questao in provaComQuestoes.Questoes)
            {
                var alternativaCorreta = questao.Alternativas.SingleOrDefault(a => a.AlternativaCorreta).Id;
                var alternativaRespondida = request.Respostas.SingleOrDefault(r => r.QuestaoId == questao.Id).AlternativaId;

                if (!string.IsNullOrEmpty(alternativaCorreta) 
                    && !string.IsNullOrEmpty(alternativaRespondida)
                    && alternativaCorreta.ToUpper().Equals(alternativaRespondida.ToUpper()))
                {
                    questoesAcertadas++;
                }
            }

            var matriculaId = _matriculaRepository.ObterPorAluno(Guid.Parse(request.UsuarioId));
            var avaliacaoMatricula = new AvaliacaoMatricula
            {
                AvaliacaoId = Guid.Parse(request.AvaliacaoId),
                MatriculaId = matriculaId,
                Nota = questoesAcertadas / Convert.ToDouble(provaComQuestoes.Questoes.Count()) * 10.0
            };

            var avaliacaoMatriculaId = _avaliacaoMatriculaRepository.Criar(avaliacaoMatricula);

            var folhaRespostas = request.Respostas.Select(f => new FolhaResposta
            {
                QuestaoId = string.IsNullOrEmpty(f.QuestaoId) ? null : Guid.Parse(f.QuestaoId),
                AlternativaId = string.IsNullOrEmpty(f.AlternativaId) ? null : Guid.Parse(f.AlternativaId),
                AvaliacaoMatriculaId = avaliacaoMatriculaId
            });

            _folhaRespostaRepository.Criar(folhaRespostas);

            response.Id = avaliacaoMatriculaId.ToString();

            return response;
        }
    }
}
