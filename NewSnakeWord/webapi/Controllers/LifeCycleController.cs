using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LifeCycleController : Controller
    {
        [HttpGet(Name = "GetLifeCycle")]
        public int Get()
        {
            return 1;
        }
    }
}
