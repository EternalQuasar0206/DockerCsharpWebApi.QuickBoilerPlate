using DockerCsharpWebApi.QuickBoilerPlate.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerCsharpWebApi.QuickBoilerPlate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult<WelcomeResponse> TextWelcomeResponse([FromQuery] string text)
        {
            return new WelcomeResponse($"Welcome! Your text is {text}");
        }
    }
}