 
using GPRC.core.application.InputPort;
using GPRC.core.application.OutputPort;
using GPRC.core.domaine.Entities;
using GPRC.persistance.Adapter;
using GPRC.persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GPRC.DependencyInjectionContainer
{
    public static class DependencyInjectionContainer
    {

         

        public static void Registerconfigurations(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultHostingConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));



        }
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IGenericCommandAsync<Dossier>, GenericCommandAsync<Dossier>>();
            services.AddScoped<IGenericRepositoryAsync<Dossier>, GenericRepositoryAsync<Dossier>>();


        }
        public static void RegisterServicesTest(IServiceCollection services)
        {

            services.AddScoped<IGenericCommandAsync<Dossier>, GenericCommandAsync<Dossier>>();
            services.AddScoped<IGenericRepositoryAsync<Dossier>, GenericRepositoryAsync<Dossier>>();


        }
    }
}
