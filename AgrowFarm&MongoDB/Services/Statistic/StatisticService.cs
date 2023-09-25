using AgrowFarm_MongoDB.Settings;
using MongoDB.Driver;

namespace AgrowFarm_MongoDB.Services.Statistic
{
    public class StatisticService : IStatisticService
    {
        private readonly IMongoCollection<Entities.Statistic> _statisticCollection;
        public StatisticService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _statisticCollection = database.GetCollection<Entities.Statistic>(_databaseSettings.StatisticCollectionName);
        }
        public async Task CreateStatistic(Entities.Statistic statistic)
        {
            await _statisticCollection.InsertOneAsync(statistic);
        }

        public async Task DeleteStatistic(string id)
        {
            await _statisticCollection.DeleteOneAsync(x => x.StatisticId == id);
        }

        public async Task<List<Entities.Statistic>> GetAllStatistic()
        {
            var values = await _statisticCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Entities.Statistic> GetByIdStatistic(string id)
        {
            var value = await _statisticCollection.Find<Entities.Statistic>(x => x.StatisticId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateStatistic(Entities.Statistic statistic)
        {
            await _statisticCollection.FindOneAndReplaceAsync(x => x.StatisticId == statistic.StatisticId, statistic);
        }
    }
}
