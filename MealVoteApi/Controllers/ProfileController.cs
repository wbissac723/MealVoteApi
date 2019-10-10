using MealVote.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVote.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
            private readonly IProfileService _profileService;

            public ProfileController(IProfileService profileService)
            {
                _profileService = profileService;
            }

            [HttpPost]
            public ActionResult CreateAccount([FromBody] ProfileRequest request)
            {
                if (request == null)
                {
                    return BadRequest();
                }

            var result = _profileService.CreateProfile(request);

                return Ok(result);
            }
        }
}
