namespace CatsServer
{
    using CatsServer.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;
    using Infrastructure;
    using System;
    using CatsServer.Infrastructure.Extentions;

    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CatDbContext>(options =>
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CatsServerDb;Integrated Security=True;"));
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
       
             => app
                .UseDatabaseMigration()
                .UseStaticFiles()
                .UseHtmlContentType()
                .UseRequestHandlers()
.UseNotFoundHandler();
       
    }
}
