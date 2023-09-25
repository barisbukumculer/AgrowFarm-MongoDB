using AgrowFarm_MongoDB.Settings;
using MongoDB.Driver;

namespace AgrowFarm_MongoDB.Services.OurService
{
    public class OurServiceService : IOurServiceService
    {
        private readonly IMongoCollection<Entities.OurService> _ourServiceCollection;
        public OurServiceService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _ourServiceCollection = database.GetCollection<Entities.OurService>(_databaseSettings.OurServiceCollectionName);
        }
        public async Task CreateOurService(Entities.OurService ourService)
        {
            await _ourServiceCollection.InsertOneAsync(ourService);
        }

        public async Task DeleteOurService(string id)
        {
            await _ourServiceCollection.DeleteOneAsync(x => x.OurServiceId == id);
        }

        public async Task<List<Entities.OurService>> GetAllOurService()
        {
            var values = await _ourServiceCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Entities.OurService> GetByIdOurService(string id)
        {
            var value = await _ourServiceCollection.Find<Entities.OurService>(x => x.OurServiceId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateOurService(Entities.OurService ourService)
        {
            await _ourServiceCollection.FindOneAndReplaceAsync(x => x.OurServiceId == ourService.OurServiceId, ourService);
        }
    }
}
