using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ag_open_gps_web.Controllers
{
    [AllowAnonymous]
    [Route("/healthz")]
    public class HealthController : BaseController
    {
        public IActionResult Get()
        {
            return Ok("pong");
        }
    }
}