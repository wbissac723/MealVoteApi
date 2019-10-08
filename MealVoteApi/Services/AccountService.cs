

using MealVote.Api.Contracts;
using MealVote.Domain;
using MealVote.Infrastructure;
using System;

namespace MealVote.Api.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public bool CreateAccount(AccountRequest request)
        {
            var success = false;

            var account = new Account
            {
                Id = new Guid(),
                Email = request.Email,
                Password = request.Password,
                UserName = request.UserName,
                AccountCreatedDate = DateTime.Now
            };

            _repository.Create(account);

            return success;
        }
    }
}
