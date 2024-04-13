using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using WebApplication2.Logic.Models;
using WebApplication2.Logic.Processors;

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

        [HttpGet("user")]
        public async Task<IActionResult> GetByName([FromQuery]string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Invalid request params");
            }
            PlaceholderResult resultData =await _dataProcessor.GetData(name);
            if (resultData == null)
            {
                return BadRequest("Not found");
            }
            return Ok(resultData);
        }
    }
}