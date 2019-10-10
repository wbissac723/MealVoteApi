using MealVote.Api.Contracts;
using MealVote.Domain;
using System.Threading.Tasks;

namespace MealVote.Api.Services
{
    public interface IAccountService
    {
        Task CreateAccount(AccountRequest request);
    }
}