using Microsoft.AspNetCore.Mvc;

namespace temp
{
    [Route("api/[controller]")]
    public class DefaultController : Controller
    {
        [Route("test")]
        [HttpPost]
        public IActionResult TestController([FromBody]string value)
        {
            return null;
        }
    }
}
