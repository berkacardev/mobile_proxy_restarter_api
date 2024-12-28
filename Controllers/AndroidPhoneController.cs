using Microsoft.AspNetCore.Mvc;
using MobileProxyApi.Helper;

namespace MobileProxyApi.Controllers
{
    public class AndroidPhoneController : Controller
    {
        [HttpGet("")]
        public IActionResult DisableAirplaneMode()
        {
            try
            {
                AdbHelper.StartProcess();
                return Ok(new { message = "Ip Changed" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred.", error = ex.Message });
            }
        }
    }
}

