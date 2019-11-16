using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ag_open_gps_web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}