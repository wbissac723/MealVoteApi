

using MealVote.Api.Contracts;
using MealVote.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace MealVote.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {

        private readonly AccountService _accountService;

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public ActionResult<AccountResponse> CreateAccount(AccountRequest account)
        {
            if (account == null)
            {
                return NotFound();
            }

            var response = new AccountResponse { Message = "Account successfully created"};

            return Ok(response);

        }
    }
}
