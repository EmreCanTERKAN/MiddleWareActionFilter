using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MiddleWareActionFilter.Filters
{
    public class TimeControllerFilter : ActionFilterAttribute
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            StartTime = "20:00";
            EndTime = "22:00";

            var now = DateTime.Now.TimeOfDay;

            if (now >= TimeSpan.Parse(StartTime) && now <= TimeSpan.Parse(EndTime))
            {
                base.OnActionExecuting(context);
            }

            else
            {
                context.Result = new ContentResult()
                {
                    Content = "Kötü Zaman ",
                    StatusCode = 403
                };
            }
            
        }
    }
}
