using Hackaton.Application.Contracts.Services.Token;
using Hackaton.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace Hackaton.Infrastructure
{
    public static class InjecaoDependencias
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
