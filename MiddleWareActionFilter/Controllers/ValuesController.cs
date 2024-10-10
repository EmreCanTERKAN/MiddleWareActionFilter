using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddleWareActionFilter.Filters;

namespace MiddleWareActionFilter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        [TestFilter]
        public IActionResult Get()
        {
            return Ok("Get apisi çalıştı");
        }

        [HttpPost]
        [TimeControllerFilter]
        public IActionResult Add()
        {
            Console.WriteLine("Gerekli kodlar Çalıştırıldı.");

            return Ok("Add post çalıştı");
        }
    }
}
