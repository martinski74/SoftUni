namespace CatsServer.Middleware
{
    using CatsServer.Data;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;


    public class DatabaseMigrationMiddleware
    {
        private readonly RequestDelegate next;

        public DatabaseMigrationMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.RequestServices.GetRequiredService<CatDbContext>().Database.Migrate();

            return this.next(context);
        }
    }
}
