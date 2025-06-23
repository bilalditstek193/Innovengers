using Microsoft.AspNetCore.Mvc;

namespace Configs.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigsController : ControllerBase
    {
        // GET: api/configs
        [HttpGet]
        public IActionResult GetConfigs()
        {
            // For demo, returning static data
            var configs = new[]
            {
                new { Id = 1, Name = "Config1", Value = "Value1" },
                new { Id = 2, Name = "Config2", Value = "Value2" }
            };

            return Ok(configs);
        }

        // GET: api/configs/{id}
        [HttpGet("{id}")]
        public IActionResult GetConfig(int id)
        {
            var config = new { Id = id, Name = $"Config{id}", Value = $"Value{id}" };

            return Ok(config);
        }
    }
}
