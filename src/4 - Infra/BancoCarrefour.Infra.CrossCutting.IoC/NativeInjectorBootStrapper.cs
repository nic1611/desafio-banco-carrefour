using System;
using System.Reflection;
using BancoCarrefour.Application.Interfaces;
using BancoCarrefour.Application.Service;
using BancoCarrefour.Domain.Commands;
using BancoCarrefour.Domain.Interfaces;
using BancoCarrefour.Domain.TelegramCommands;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BancoCarrefour.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddMediatR(typeof(TelegramBotCommand).GetTypeInfo().Assembly);

            services.AddScoped<ITelegramAppService, TelegramAppService>();

            services.AddScoped<ITelegramCommand, AutoatendimentoTC>();
            services.AddScoped<ITelegramCommand, CentralTelefonicaTC>();
            services.AddScoped<ITelegramCommand, DuvidasFrequentesTC>();
            services.AddScoped<ITelegramCommand, EstandeTC>();
            services.AddScoped<ITelegramCommand, FaleConoscoTC>();
            services.AddScoped<ITelegramCommand, OuvidoriaTC>();
        }
    }
}
