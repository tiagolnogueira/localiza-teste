using Localiza.Teste.Application.Interfaces;
using Localiza.Teste.Application.Notificacoes;
using Localiza.Teste.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Localiza.Teste.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IMathService, MathService>();

            return services;
        }
    }
}