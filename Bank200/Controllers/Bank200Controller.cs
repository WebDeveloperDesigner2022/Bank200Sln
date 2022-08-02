using Bank200.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bank200.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Bank200Controller : ControllerBase
    {
        private readonly SystemDB _systemDB;
        public Bank200Controller(SystemDB systemDB)
        {
            _systemDB = systemDB;
        }
        [HttpGet]
        public IActionResult MakeDeposit([FromBody])
        {
            return Ok();
        }
    }
}
