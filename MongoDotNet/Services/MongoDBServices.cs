using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDotNet.Models;

namespace MongoDotNet.Services
{
    public class MongoDBServices
    {
        private readonly IMongoCollection<User> _usersCollection;
        public MongoDBServices(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _usersCollection = database.GetCollection<User>(mongoDBSettings.Value.CollectionName);
        }

        public async Task CreateAsync(User user)
        {
            await _usersCollection.InsertOneAsync(user);
            return;
        }

        public async Task<List<User>> GetAsync()
        {
            return await _usersCollection.Find(new BsonDocument()).ToListAsync();
        }
    }
}
