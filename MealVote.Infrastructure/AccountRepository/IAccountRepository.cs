
using MealVote.Domain;
using System;
using System.Threading.Tasks;

namespace MealVote.Infrastructure
{
    public interface IAccountRepository
    {
        public bool Login(string username, string password);
        public Task Create(Account account);
        public bool Delete(Guid id);

    }
}
