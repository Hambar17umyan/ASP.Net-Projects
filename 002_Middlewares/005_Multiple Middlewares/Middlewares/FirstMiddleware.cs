using _005_Multiple_Middlewares.Data;

namespace _005_Multiple_Middlewares.Middlewares
{
    public class FirstMiddleware : CustomMiddleware
    {
        public FirstMiddleware(RequestDelegate next) : base(next)
        {

        }
    }
}
