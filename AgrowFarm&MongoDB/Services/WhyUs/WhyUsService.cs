using AgrowFarm_MongoDB.Settings;
using MongoDB.Driver;

namespace AgrowFarm_MongoDB.Services.WhyUs
{
    public class WhyUsService : IWhyUsService
    {
        private readonly IMongoCollection<Entities.WhyUs> _whyUsCollection;
        public WhyUsService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _whyUsCollection = database.GetCollection<Entities.WhyUs>(_databaseSettings.WhyUsCollectionName);
        }
        public async Task CreateWhyUs(Entities.WhyUs whyUs)
        {
            await _whyUsCollection.InsertOneAsync(whyUs);
        }

        public async Task DeleteWhyUs(string id)
        {
            await _whyUsCollection.DeleteOneAsync(x => x.WhyUsId == id);
        }

        public async Task<List<Entities.WhyUs>> GetAllWhyUs()
        {
            var values = await _whyUsCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Entities.WhyUs> GetByIdWhyUs(string id)
        {
            var value = await _whyUsCollection.Find<Entities.WhyUs>(x => x.WhyUsId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateWhyUs(Entities.WhyUs whyUs)
        {
            await _whyUsCollection.FindOneAndReplaceAsync(x => x.WhyUsId == whyUs.WhyUsId, whyUs);
        }
    }
}
