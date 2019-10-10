using MealVote.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVote.Api.Contracts
{
    public class ProfileRequest
    {
        public string UserName { get; set; }
        public string AvatarUrl { get; set; } = "";
        public Restaurant FavoriteSpot { get; set; } = null;
        public List<Tribe> Tribes { get; set; } = null;
    }
}
