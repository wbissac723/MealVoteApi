
using System;
using System.Threading.Tasks;
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

        public async Task<bool> Create(Profile profile)
        {
            bool success = false;

            try
            {
                await _profiles.InsertOneAsync(profile);
                success = true;
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return success;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
