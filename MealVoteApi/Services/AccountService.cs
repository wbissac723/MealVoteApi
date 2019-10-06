

using MealVote.Domain;
using MealVote.Infrastructure;
using System;

namespace MealVote.Api.Services
{
    public class AccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public bool CreateAccount(string email, string username, string password)
        {
            var success = false;

            var account = new Account
            {
                Id = new Guid(),
                Email = email,
                Password = password,
                UserName = username,
                AccountCreatedDate = new DateTime(2019, 10, 06)
            };

            _repository.Create(account);

            return success;
        }
    }
}
