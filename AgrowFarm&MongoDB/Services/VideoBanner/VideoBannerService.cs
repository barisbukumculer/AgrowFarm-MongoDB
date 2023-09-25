using AgrowFarm_MongoDB.Settings;
using MongoDB.Driver;

namespace AgrowFarm_MongoDB.Services.VideoBanner
{
    public class VideoBannerService : IVideoBannerService
    {
        private readonly IMongoCollection<Entities.VideoBanner> _videoBannerCollection;
        public VideoBannerService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _videoBannerCollection = database.GetCollection<Entities.VideoBanner>(_databaseSettings.VideoBannerCollectionName);
        }
        public async Task CreateVideoBanner(Entities.VideoBanner videoBanner)
        {
            await _videoBannerCollection.InsertOneAsync(videoBanner);
        }

        public async Task DeleteVideoBanner(string id)
        {
            await _videoBannerCollection.DeleteOneAsync(x => x.VideoBannerId == id);
        }

        public async Task<List<Entities.VideoBanner>> GetAllVideoBanner()
        {
            var values = await _videoBannerCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Entities.VideoBanner> GetByIdVideoBanner(string id)
        {
            var value = await _videoBannerCollection.Find<Entities.VideoBanner>(x => x.VideoBannerId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateVideoBanner(Entities.VideoBanner videoBanner)
        {
            await _videoBannerCollection.FindOneAndReplaceAsync(x => x.VideoBannerId == videoBanner.VideoBannerId, videoBanner);
        }
    }
}
