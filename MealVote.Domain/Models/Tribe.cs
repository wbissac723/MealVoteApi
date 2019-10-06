using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MealVote.Domain
{
    public class Tribe
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Leader { get; set; }
        public List<Profile> Members { get; set; }
        public DateTime DateCreated { get; set; }
        public string Location { get; set; }
        public Restaurant PreviousVisit { get; set; }
        public List<History> History { get; set; }
    }
}