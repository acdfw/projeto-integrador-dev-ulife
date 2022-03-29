using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureData(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("IntegradorDb");

            services.AddDbContext<IntegradorContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
