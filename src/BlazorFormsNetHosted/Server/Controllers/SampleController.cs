using BlazorFormsNetHosted.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFormsNetHosted.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public ActionResult Test([FromQuery]SampleDto sampleDto)
        {
            return Ok();
        }
    }
}
