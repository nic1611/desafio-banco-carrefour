using System;
using System.IO;
using BancoCarrefour.Infra.CrossCutting.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BancoCarrefour.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
           

            Console.WriteLine($"environmentName = {environmentName}");
            Console.WriteLine($"CurrentDirectory = {Directory.GetCurrentDirectory()}");

            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddJsonFile($"appsettings.{environmentName}.json", optional: true);

            builder.AddEnvironmentVariables();

            var configuration = builder.Build();

            var services = new ServiceCollection();

            // .NET Native DI Abstraction
            NativeInjectorBootStrapper.RegisterServices(services, configuration);
            services.AddScoped<Bot>();

            var serviceProvider = services.BuildServiceProvider();

            try
            {
                var appService = serviceProvider.GetService<Bot>();
                Console.ReadKey();

            }
            catch (Exception)
            {
                Environment.Exit(1);
            }
            finally
            {
                 Environment.Exit(0);
            }
        }
    }
}
