using Hackaton.Application.Contracts.Presenters;
using Hackaton.Application.Contracts.UseCases.Autenticacao;
using Hackaton.Application.Contracts.UseCases.Medicos;
using Hackaton.Application.Contracts.UseCases.Usuarios;
using Hackaton.Application.Presenters;
using Hackaton.Application.UseCases.Autenticacao;
using Hackaton.Application.UseCases.Medicos;
using Hackaton.Application.UseCases.Usuarios;
using Microsoft.Extensions.DependencyInjection;

namespace Hackaton.Application
{
    public static class InjecaoDependencias
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioCadastrarMedicoUseCase, UsuarioCadastrarMedicoUseCase>();
            services.AddScoped<IUsuarioCadastrarPacienteUseCase, UsuarioCadastrarPacienteUseCase>();
            services.AddScoped<IMedicoBuscarTodosUseCase, MedicoBuscarTodosUseCase>();
            services.AddScoped<IUsuarioAutenticarMedicoUseCase, UsuarioAutenticarMedicoUseCase>();
            services.AddScoped<IUsuarioAutenticarPacienteUseCase, UsuarioAutenticarPacienteUseCase>();

            services.AddScoped<IUsuarioPresenter, UsuarioPresenter>();
            return services;
        }
    }
}
