using Microsoft.AspNetCore.Mvc;
using WebApplication.Logic.Processors;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly PlaceholderDataProcessor _dataProcessor;
        public HomeController(PlaceholderDataProcessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
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