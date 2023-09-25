namespace AgrowFarm_MongoDB.Services.Statistic
{
    public interface IStatisticService
    {
        Task<List<Entities.Statistic>> GetAllStatistic();
        Task<Entities.Statistic> GetByIdStatistic(string id);
        Task CreateStatistic(Entities.Statistic statistic);
        Task UpdateStatistic(Entities.Statistic statistic);
        Task DeleteStatistic(string id);
    }
}
