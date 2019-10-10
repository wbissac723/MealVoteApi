
using MealVote.Domain;
using System;
using System.Threading.Tasks;

namespace MealVote.Infrastructure
{
    public interface IProfileRepository
    {
        public Task<bool> Create(Profile profile);
        public void Delete(Guid id);

    }
}
