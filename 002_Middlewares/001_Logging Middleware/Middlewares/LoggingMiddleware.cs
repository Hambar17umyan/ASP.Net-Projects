
using _001_Logging_Middleware.Data;
using _001_Logging_Middleware.Serializers;

namespace _001_Logging_Middleware.Middlewares
{
    public class LoggingMiddleware
    {
        public RequestDelegate _next;
        public Task InvokeAsync(HttpContext context)
        {
            string res = new HTTPContextSerializer().SerializeCSV(context);
            try
            {
                DataRepository.Log(res);
                _next(context);
            }
            catch (Exception)
            {
                context.Response.StatusCode = 500;
            }
            return Task.CompletedTask;
        }

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
    }
}
