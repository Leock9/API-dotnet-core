using Microsoft.Extensions.DependencyInjection;
using TesteApi.ConfigUnitOfWork.UnitOfWork;
using TesteApi.Interface.IUnitOfWork;
using TesteApi.Interface.Repositories.IAlunoRepository;
using TesteApi.Interface.Services.IAlunoService;
using TesteApi.Repositories.AlunoRepository;
using TesteApi.Services.AlunoService;

namespace TesteApi.DependencyInjectionConfig 
{
    public static class DependencyInjectionConfig 
    {
       public static IServiceCollection AddServices(this IServiceCollection services) 
       {
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

           return services;
       } 
    }
}