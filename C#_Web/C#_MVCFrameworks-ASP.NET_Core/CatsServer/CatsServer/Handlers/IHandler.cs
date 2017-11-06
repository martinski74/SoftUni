
using Microsoft.AspNetCore.Http;
using System;

namespace CatsServer.Handlers
{
    public interface IHandler
    {
        int Order { get; }

        Func<HttpContext, bool> Condition { get; }

        RequestDelegate RequestHandler { get; }
    }
}
