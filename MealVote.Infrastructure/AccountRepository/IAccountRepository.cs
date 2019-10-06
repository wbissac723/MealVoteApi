
using MealVote.Domain;
using System;

namespace MealVote.Infrastructure
{
    public interface IAccountRepository
    {
        public bool Login(string username, string password);
        public bool Create(Account account);
        public bool Delete(Guid id);

    }
}
