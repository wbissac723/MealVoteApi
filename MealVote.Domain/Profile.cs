using System.Collections.Generic;


namespace MealVote.Domain
{
    public class Profile
    {
        public string UserName { get; set; }
        public string AvatarUrl { get; set; }
        public Restaurant FavoriteSpot { get; set; }
        public List<Tribe> Tribes { get; set; }
    }
}
