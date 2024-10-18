using _005_Multiple_Middlewares.Data;

namespace _005_Multiple_Middlewares.Middlewares
{
    public abstract class CustomMiddleware
    {
        RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;   
        }

        public virtual Task InvokeAsync(HttpContext context)
        {
            DataRepository.Log("Entered " + GetType().Name);
            _next(context);
            DataRepository.Log("Left " + GetType().Name);
            return Task.CompletedTask;
        }
    }
}
