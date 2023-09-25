using AgrowFarm_MongoDB.Settings;
using MongoDB.Driver;

namespace AgrowFarm_MongoDB.Services.Testimonial
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IMongoCollection<Entities.Testimonial> _testimonialCollection;
        public TestimonialService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _testimonialCollection = database.GetCollection<Entities.Testimonial>(_databaseSettings.TestimonialCollectionName);
        }
        public async Task CreateTestimonial(Entities.Testimonial testimonial)
        {
            await _testimonialCollection.InsertOneAsync(testimonial);
        }

        public async Task DeleteTestimonial(string id)
        {
            await _testimonialCollection.DeleteOneAsync(x => x.TestimonialId == id);
        }

        public async Task<List<Entities.Testimonial>> GetAllTestimonial()
        {
            var values = await _testimonialCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Entities.Testimonial> GetByIdTestimonial(string id)
        {
            var value = await _testimonialCollection.Find<Entities.Testimonial>(x => x.TestimonialId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateTestimonial(Entities.Testimonial testimonial)
        {
            await _testimonialCollection.FindOneAndReplaceAsync(x => x.TestimonialId == testimonial.TestimonialId, testimonial);
        }
    }
}
