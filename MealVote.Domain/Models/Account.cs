using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MealVote.Domain
{
    public class Account
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonElement("Username")]
        public string UserName { get; set; }
        
        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("AccountCreationDate")]
        public DateTime AccountCreatedDate { get; set; }
    }
}
