using MealVote.Api.Contracts;
using System.Threading.Tasks;

namespace MealVote.Api.Controllers
{
    public interface IProfileService
    {
        Task CreateProfile(ProfileRequest request);
    }
}