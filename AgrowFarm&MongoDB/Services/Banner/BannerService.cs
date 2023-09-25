using AgrowFarm_MongoDB.Settings;
using MongoDB.Driver;

namespace AgrowFarm_MongoDB.Services.Banner
{
    public class BannerService : IBannerService
    {
        private readonly IMongoCollection<Entities.Banner> _bannerCollection;
        public BannerService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _bannerCollection = database.GetCollection<Entities.Banner>(_databaseSettings.BannerCollectionName);
        }
        public async Task CreateBanner(Entities.Banner banner)
        {
            await _bannerCollection.InsertOneAsync(banner);
        }

        public async Task DeleteBanner(string id)
        {
            await _bannerCollection.DeleteOneAsync(x => x.BannerId == id);
        }

        public async Task<List<Entities.Banner>> GetAllBanner()
        {
            var values = await _bannerCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Entities.Banner> GetByIdBanner(string id)
        {
            var value = await _bannerCollection.Find<Entities.Banner>(x => x.BannerId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateBanner(Entities.Banner banner)
        {
            var result = await _bannerCollection.FindOneAndReplaceAsync(x => x.BannerId == banner.BannerId, banner);
        }
    }
}
