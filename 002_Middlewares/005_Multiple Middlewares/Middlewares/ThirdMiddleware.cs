namespace _005_Multiple_Middlewares.Middlewares
{
    internal class ThirdMiddleware : CustomMiddleware
    {
        public ThirdMiddleware(RequestDelegate next) : base(next)
        {
            
        }
    }
}