using MealVote.Api.Contracts;
using MealVote.Api.Controllers;
using MealVote.Domain;
using MealVote.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVote.Api.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _repository;

        public ProfileService(IProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateProfile(ProfileRequest request)
        {
            var profile = new Profile
            {
                Id = new Guid(),
                AvatarUrl = request.AvatarUrl ?? "",
                FavoriteSpot = request.FavoriteSpot ?? null,
                Tribes = request.Tribes ?? null,
                UserName = request.UserName,
                
            };

            await _repository.Create(profile);
        }
    }
}
