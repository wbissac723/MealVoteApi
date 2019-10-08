

using MealVote.Api.Contracts;
using MealVote.Api.Services;
using MealVote.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public void CreateAccount([FromBody] AccountRequest account)
        {
            //if (account == null)
            //{
            //    return BadRequest();
            //}

            _accountService.CreateAccount(account);


            //return Ok(response);

        }
    }
}
