using Microsoft.AspNetCore.Mvc.Filters;

namespace MiddleWareActionFilter.Filters
{
    public class TestFilter : ActionFilterAttribute
    {

        // genellikle bunu çalıştırıyoruz. 

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("OnActionExecuting -Action Çalışırken en başta-");
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted - Action Çalıştıktan Sonra");
            base.OnActionExecuted(context);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("OnResultExecuting - Cevap dönerken (hemen önce)");
            base.OnResultExecuting(context);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("OnResultExecuted - Cevap döndükten sonra");
            base.OnResultExecuted(context);
        }
    }
}
