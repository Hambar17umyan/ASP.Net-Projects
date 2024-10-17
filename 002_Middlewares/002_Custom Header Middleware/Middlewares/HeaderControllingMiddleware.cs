
namespace _002_Custom_Header_Middleware.Middlewares
{
    public class HeaderControllingMiddleware
    {
        RequestDelegate _next;

        public HeaderControllingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task InvokeAsync(HttpContext context)
        {
            context.Response.Headers.Add(KeyValuePair.Create(GetType().Name, new Microsoft.Extensions.Primitives.StringValues(DateTime.Now.ToString())));
            return Task.CompletedTask;
        }
    }
}
