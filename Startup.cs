using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TesteApi.Data.DataContext;
using TesteApi.Interface.Repositories.IAlunoRepository;
using TesteApi.Interface.Services.IAlunoService;
using TesteApi.Repositories.AlunoRepository;
using TesteApi.Services.AlunoService;

namespace TesteApi
{
    public class Startup
    {
        private IConfiguration _configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var connectionString = _configuration.GetConnectionString("DataContext");

            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
