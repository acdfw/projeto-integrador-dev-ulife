using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.ProjetoIntegrador.Domain.Shared.Responses
{
    public class ProvaTurmaQuestoesResponse
    {
        public string IdentificadorProva { get; set; }
        public string? NomeTurma { get; set; }
        public IList<QuestaoResponse> Questoes { get; set; }
    }
}
