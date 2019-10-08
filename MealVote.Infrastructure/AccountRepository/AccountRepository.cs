using MealVote.Api;
using MealVote.Domain;
using MongoDB.Driver;
using System;

namespace MealVote.Infrastructure
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMongoCollection<Account> _accounts;
        private const string databaseName = "MealVote";
        private const string collection = "Accounts";
        private const string connectionString = "mongodb://localhost:27017";


        public AccountRepository()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            _accounts = database.GetCollection<Account>(collection);
        }

        public bool Create(Account account)
        {
            var success = false;

            _accounts.InsertOne(account);

            return success;
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
