namespace AgrowFarm_MongoDB.Services.VideoBanner
{
    public interface IVideoBannerService
    {
        Task<List<Entities.VideoBanner>> GetAllVideoBanner();
        Task<Entities.VideoBanner> GetByIdVideoBanner(string id);
        Task CreateVideoBanner(Entities.VideoBanner videoBanner);
        Task UpdateVideoBanner(Entities.VideoBanner videoBanner);
        Task DeleteVideoBanner(string id);
    }
}
