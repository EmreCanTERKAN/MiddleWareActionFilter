namespace MiddleWareActionFilter.Middlewares
{
    public static class MiddleWareExtensions
    {
        public static IApplicationBuilder UseMaintenenceMode(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MaintenenceModeMiddleware>();
        }
    }
}
