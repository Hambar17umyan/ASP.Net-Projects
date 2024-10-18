
namespace _006_User_Activity_Checking.Middlewares
{
    public class UserInfoLoggingMiddleware
    {
        RequestDelegate _next;

        public UserInfoLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task InvokeAsync(HttpContext context)
        {
            _next(context);
            return Task.CompletedTask;
        }
    }
}
