using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;


namespace MealVote.Domain
{
    public class Profile
    {
        [BsonId]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string AvatarUrl { get; set; }
        public Restaurant FavoriteSpot { get; set; }
        public List<Tribe> Tribes { get; set; }
    }
}
