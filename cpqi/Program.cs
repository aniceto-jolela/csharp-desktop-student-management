using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using cpqi.Data;
using cpqi.Data.Repositories;
using cpqi.ViewModels;
using Microsoft.Extensions.Configuration;
using cpqi.Views.Admin;

namespace cpqi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Criação do Host para configurar serviços e DI
            var host = CreateHostBuilder(args).Build();

            var loginForm = host.Services.GetRequiredService<Login>();
            Application.Run(loginForm);
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureServices((context, services) =>
               {
                   services.AddDbContext<CpqiDbContext>(options =>
                       options.UseSqlServer(context.Configuration.GetConnectionString("CpqiDB")));

                   services.AddScoped<UserRepository>();
                   services.AddScoped<RoleRepository>();
                   services.AddScoped<UserViewModel>();
                   services.AddScoped<FormManager>();
                   services.AddScoped<Login>();
               });
    }
}