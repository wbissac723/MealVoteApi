

using MealVote.Api.Contracts;
using MealVote.Api.Services;
using MealVote.Domain;
using Microsoft.AspNetCore.Mvc;


namespace MealVote.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {

        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public ActionResult CreateAccount([FromBody] AccountRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var result = _accountService.CreateAccount(request);

            return Ok(result);
        }
    }
}
