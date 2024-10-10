namespace MiddleWareActionFilter.Middlewares
{
    public class MaintenenceModeMiddleware
    {
        private readonly RequestDelegate _next;

        public MaintenenceModeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            bool maintenence = false; // Bu dbden çekilebilir.

            if (maintenence)
            {
                await context.Response.WriteAsync("Bakımdayız.");
            }
            else
            {
                await _next(context);
            }
        }
    }
}
