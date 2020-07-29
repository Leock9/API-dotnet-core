using Microsoft.Extensions.DependencyInjection;
using TesteApi.Interface.Repositories.IAlunoRepository;
using TesteApi.Interface.Services.IAlunoService;
using TesteApi.Repositories.AlunoRepository;
using TesteApi.Services.AlunoService;

namespace TesteApi.DependencyInjectionConfig 
{
    public static class DependencyInjectionConfig 
    {
       public static IServiceCollection ResolveDependencies(this IServiceCollection services) 
       {
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();

           return services;
       } 
    }
}