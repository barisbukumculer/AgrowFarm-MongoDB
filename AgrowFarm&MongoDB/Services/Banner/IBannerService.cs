namespace AgrowFarm_MongoDB.Services.Banner
{
    public interface IBannerService
    {
        Task<List<Entities.Banner>> GetAllBanner();
        Task<Entities.Banner> GetByIdBanner(string id);
        Task CreateBanner(Entities.Banner banner);
        Task UpdateBanner(Entities.Banner banner);
        Task DeleteBanner(string id);
    }
}
