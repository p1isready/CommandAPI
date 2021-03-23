using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/command")] 
    [ApiController] // Automatic HTTP 4xx Error responses (not mandatory)
    public class CommandsController: ControllerBase{
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"this", "is", "hard", "coded", "tefgdfgst"};
         }
    }
}