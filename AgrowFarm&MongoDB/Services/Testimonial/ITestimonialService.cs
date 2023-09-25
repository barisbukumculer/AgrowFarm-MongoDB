namespace AgrowFarm_MongoDB.Services.Testimonial
{
    public interface ITestimonialService
    {
        Task<List<Entities.Testimonial>> GetAllTestimonial();
        Task<Entities.Testimonial> GetByIdTestimonial(string id);
        Task CreateTestimonial(Entities.Testimonial testimonial);
        Task UpdateTestimonial(Entities.Testimonial testimonial);
        Task DeleteTestimonial(string id);
    }
}
