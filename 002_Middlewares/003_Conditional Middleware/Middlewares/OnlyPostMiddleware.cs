
namespace _003_Conditional_Middleware.Middlewares
{
    public class OnlyPostMiddleware
    {

        RequestDelegate _next;

        public OnlyPostMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task InvokeAsync(HttpContext context)
        {
            if(context.Request.Method == "POST")
            {
                Console.WriteLine("POST");
                context.Response.Headers.Add(KeyValuePair.Create(GetType().Name, new Microsoft.Extensions.Primitives.StringValues(DateTime.Now.ToString())));
                return Task.CompletedTask;
            }

            _next(context);
            return Task.CompletedTask;
        }
    }
}
