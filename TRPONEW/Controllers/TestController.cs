


using Microsoft.AspNetCore.Mvc;

namespace TRPONEW.TestController
{
    public class TestController : Controller
    {
        [HttpGet("api/user")]
        public IActionResult Get()
        {
            return Ok(new { name = "Gofman" });
        }
        
    }
}