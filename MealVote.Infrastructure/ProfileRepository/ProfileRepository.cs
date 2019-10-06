
using System;
using MealVote.Domain;
using MongoDB.Driver;

namespace MealVote.Infrastructure
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly IMongoCollection<Profile> _profiles;
        private const string databaseName = "MealVote";
        private const string collection = "Profiles";
        private const string connectionString = "mongodb://localhost:27017";


        public ProfileRepository()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            _profiles = database.GetCollection<Profile>(collection);
        }

        public void Create(Profile profile)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
