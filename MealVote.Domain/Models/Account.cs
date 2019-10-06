using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MealVote.Domain
{
    public class Account
    {
        [BsonId]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime AccountCreatedDate { get; set; }
    }
}
