using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        [Authorize(Policy = "RequireAdminRole")]
        [HttpGet("usersWithRoles")]
        public IActionResult GetUsersWithRoles()
        {
            return Ok("Only admins can see this");
        }

        [Authorize(Policy = "ModeratePhotoRole")]
        [HttpGet("photoForModerations")]
        public IActionResult GetPhotosForModeration()
        {
            return Ok("Amins and moderators can see this");
        }
    }
}