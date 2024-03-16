using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
        }

        [HttpGet("healthCheck")]
        public IActionResult HealthCheck() 
        {
            return Ok(new List<string>(){
                "Дима",
                    "Вася"
            });
        }
    }
}