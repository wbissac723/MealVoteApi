
using MealVote.Domain;
using System;

namespace MealVote.Infrastructure
{
    public interface IProfileRepository
    {
        public void Create(Profile profile);
        public void Delete(Guid id);

    }
}
