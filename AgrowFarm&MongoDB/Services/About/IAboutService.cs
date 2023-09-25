namespace AgrowFarm_MongoDB.Services.About
{
   
        public interface IAboutService
        {
            Task<List<Entities.About>> GetAllAbout();
            Task<Entities.About> GetByIdAbout(string id);
            Task CreateAbout(Entities.About about);
            Task UpdateAbout(Entities.About about);
            Task DeleteAbout(string id);
        }
    
}
