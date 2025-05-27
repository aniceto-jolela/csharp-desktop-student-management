using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using cpqi.Data;
using cpqi.Data.Repositories;
using cpqi.ViewModels;
using Microsoft.Extensions.Configuration;
using cpqi.Views.Admin;
using System.Security.Cryptography;

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

            
            try
            {
               

                while (true)
                {
                    // Criação do Host para configurar serviços e DI
                    var host = CreateHostBuilder(args).Build();
                    using var scope = host.Services.CreateScope();

                    var services = scope.ServiceProvider;
                    var loginForm = services.GetRequiredService<Login>();
                    
                    var result = loginForm.ShowDialog();

                    var userViewModel = services.GetRequiredService<UserViewModel>();
                    if (result != DialogResult.OK || userViewModel.LoggedUser == null)
                        break;
                    Application.Run();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar a aplicação: {ex.Message}");
            }
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
                   services.AddScoped<RoleViewModel>();
                   services.AddScoped<FormManager>();
                   services.AddScoped<Login>();
               });
    }
}