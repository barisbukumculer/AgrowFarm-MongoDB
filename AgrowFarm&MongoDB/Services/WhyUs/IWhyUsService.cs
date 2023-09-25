namespace AgrowFarm_MongoDB.Services.WhyUs
{
    public interface IWhyUsService
    {
        Task<List<Entities.WhyUs>> GetAllWhyUs();
        Task<Entities.WhyUs> GetByIdWhyUs(string id);
        Task CreateWhyUs(Entities.WhyUs whyUs);
        Task UpdateWhyUs(Entities.WhyUs whyUs);
        Task DeleteWhyUs(string id);
    }
}
