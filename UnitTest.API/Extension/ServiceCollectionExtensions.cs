using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UnitTest.Domain.Interface;
using UnitTest.Infra;
using UnitTest.Infra.Repositories;

namespace UnitTest.API.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services){
            services.AddTransient<IRepository, Repository>();
        }
        
        public static void AddServices(this IServiceCollection services){
            // services.AddTransient<ISaveZendeskService, SaveZendeskService>();
        }

        public static void AddOtherDependencies(this IServiceCollection services)
        {
            // services.AddTransient<ILogService, LogService>();
        }
        
        public static void AddPgsqlConnection(this IServiceCollection services)
        {
            services.AddDbContext<Context>(options => 
                options.UseNpgsql(Environment.GetEnvironmentVariable("DB") ?? string.Empty)
            );

        }
    }
}