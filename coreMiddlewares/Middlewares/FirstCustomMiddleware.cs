using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace coreAuthenticationMiddlewares.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class FirstCustomMiddleware
    {
        private readonly RequestDelegate _next;

        public FirstCustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            return httpContext.Response.WriteAsync("This is my custom middleware.");
            // return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class FirstCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseFirstCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<FirstCustomMiddleware>();
        }
    }
}
