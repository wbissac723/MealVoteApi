using MealVote.Api.Contracts;
using MealVote.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MealVote.Api.Controllers {
    [Authorize]
    [ApiController]
    [Route ("api/[controller]")]
    public class AccountController : ControllerBase {

        private readonly IAccountService _accountService;

        public AccountController (IAccountService accountService) {
            _accountService = accountService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult CreateAccount ([FromBody] AccountRequest request) {
            var profile = _accountService.CreateAccount (request);

            if (profile == null) {
                return BadRequest (new { message = "Your request is bad." });
            }

            return Ok (profile);
        }
    }
}