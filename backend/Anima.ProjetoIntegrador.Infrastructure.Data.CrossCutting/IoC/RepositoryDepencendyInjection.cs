using Anima.ProjetoIntegrador.Domain.Interfaces;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.CrossCutting.IoC
{
    public static class RepositoryDepencendyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAlternativaRepository, AlternativaRepository>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<IAvaliacaoMatriculaRepository, AvaliacaoMatriculaRepository>();
            services.AddScoped<IMatriculaRepository, MatriculaRepository>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();
            services.AddScoped<IProvaRepository,ProvaRepository>();
            services.AddScoped<IProvaQuestaoRepository,ProvaQuestaoRepository>();
            services.AddScoped<IQuestaoRepository, QuestaoRepository>();
            services.AddScoped<ITurmaRepository, TurmaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            
            return services;
        }
    }
}
