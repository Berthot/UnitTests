using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UnitTest.API.Extension;
using UnitTest.Domain.Interface;
using UnitTest.Infra.Repositories;

namespace UnitTest.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServices();
            services.AddOtherDependencies();
            services.AddRepositories();
            services.AddPgsqlConnection();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
            });
        }
    }
}