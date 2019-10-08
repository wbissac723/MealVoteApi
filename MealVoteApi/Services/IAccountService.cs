using MealVote.Api.Contracts;

namespace MealVote.Api.Services
{
    public interface IAccountService
    {
        bool CreateAccount(AccountRequest request);
    }
}