using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionPattern_Sample_Core.IServices;

namespace OnionPattern_Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ITestService _testService;
        public MainController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAction(){

            return Ok(await _testService.GetListofWelcomeMessage());
        
        }
    }
}
