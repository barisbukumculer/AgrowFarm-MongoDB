using AgrowFarm_MongoDB.Settings;
using MongoDB.Driver;

namespace AgrowFarm_MongoDB.Services.About
{
    public class AboutService : IAboutService
    {
        private readonly IMongoCollection<Entities.About> _aboutCollection;
        public AboutService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _aboutCollection = database.GetCollection<Entities.About>(_databaseSettings.AboutCollectionName);
        }
        public async Task CreateAbout(Entities.About about)
        {
            await _aboutCollection.InsertOneAsync(about);
        }

        public async Task DeleteAbout(string id)
        {
            var values = await _aboutCollection.DeleteOneAsync(x => x.AboutId == id);
        }

        public async Task<List<Entities.About>> GetAllAbout()
        {
            var values = await _aboutCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Entities.About> GetByIdAbout(string id)
        {
            var value = await _aboutCollection.Find<Entities.About>(x => x.AboutId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateAbout(Entities.About about)
        {
            var result = await _aboutCollection.FindOneAndReplaceAsync(x => x.AboutId == about.AboutId, about);
        }
    }
}