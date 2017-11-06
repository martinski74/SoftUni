
using CatsServer.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CatsServer.Middleware
{
    public class HtmlContentTypeMiddleWare
    {
        private readonly RequestDelegate next;

        public HtmlContentTypeMiddleWare(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Response.Headers.Add(HttpHeader.ContentType, "text/html");

            return this.next(context);
        }
    }
}
