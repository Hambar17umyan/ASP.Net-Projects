using Microsoft.AspNetCore.Mvc;

namespace _006_User_Activity_Checking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyWebsiteController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "";
        }
    }
}
