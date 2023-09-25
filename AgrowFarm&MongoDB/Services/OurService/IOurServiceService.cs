namespace AgrowFarm_MongoDB.Services.OurService
{
    public interface IOurServiceService
    {
        Task<List<Entities.OurService>> GetAllOurService();
        Task<Entities.OurService> GetByIdOurService(string id);
        Task CreateOurService(Entities.OurService ourService);
        Task UpdateOurService(Entities.OurService ourService);
        Task DeleteOurService(string id);
    }
}
