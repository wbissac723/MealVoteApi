

using MealVote.Api.Contracts;
using MealVote.Domain;
using MealVote.Infrastructure;
using System;
using System.Threading.Tasks;

namespace MealVote.Api.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAccount(AccountRequest request)
        {
            var account = new Account
            {
                Id = new Guid(),
                Email = request.Email,
                Password = request.Password,
                UserName = request.UserName,
                AccountCreatedDate = DateTime.Now
            };

              await _repository.Create(account);
        }
    }
}
