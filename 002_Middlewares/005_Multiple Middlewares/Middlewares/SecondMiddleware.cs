namespace _005_Multiple_Middlewares.Middlewares
{
    internal class SecondMiddleware : CustomMiddleware
    {
        public SecondMiddleware(RequestDelegate next) : base(next)
        {
            
        }
    }
}