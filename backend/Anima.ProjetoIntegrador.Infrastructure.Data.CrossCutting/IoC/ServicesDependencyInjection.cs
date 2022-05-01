using Anima.ProjetoIntegrador.Application.Services;
using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.CrossCutting.IoC
{
    public static class ServicesDependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProfessorService, ProfessorService>();
            services.AddScoped<IProvaService, ProvaService>();
            services.AddScoped<IProvaQuestaoService, ProvaQuestaoService>();
            services.AddScoped<IQuestaoService, QuestaoService>();
            services.AddScoped<ITurmaService, TurmaService>();
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IAvaliacaoService, AvaliacaoService>();
            services.AddScoped<IAvaliacaoMatriculaService, AvaliacaoMatriculaService>();
            services.AddScoped<IAlternativaService, AlternativaService>();
            services.AddScoped<ILoginService, LoginService>();

            return services;
        }
    }
}
