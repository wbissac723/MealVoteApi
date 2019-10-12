using MealVote.Api;
using MealVote.Domain;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MealVote.Infrastructure
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMongoCollection<Account> _accounts;
        private readonly IMongoCollection<Profile> _profiles;
        
        private const string databaseName = "mealvote";
        private const string accountCollection = "Accounts";
        private const string profileCollection = "Profiles";
        private const string connectionString = "mongodb://tempdevuser:abcd1234@ds139295.mlab.com:39295/meal-vote";

        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;


        public AccountRepository()
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(databaseName);

            _accounts = _database.GetCollection<Account>(accountCollection);
            _profiles = _database.GetCollection<Profile>(profileCollection);
        }

        public async Task Create(Account account)
        {
            var profile = new Profile
            { 
                UserName = account.UserName,
                Id = account.Id
            };


            // Create a session object that is used when leveraging transactions
            using (var session = await _client.StartSessionAsync())
            {

                // Begin transaction
                session.StartTransaction();

                try
                {
                    await _accounts.InsertOneAsync(account);
                    await _profiles.InsertOneAsync(profile);

                    // Commit transaction after both succesfully database inserts
                    await session.CommitTransactionAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error writing to MongoDB: " + e);

                    // Cancel the transaction
                    await session.AbortTransactionAsync();
                }
            }
        }

        public void Delete(Guid id)
        {
            _accounts.DeleteOne(account => account.Id == id);
        }

        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        bool IAccountRepository.Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        bool IAccountRepository.Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
