using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarm_MongoDB.Entities
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string TestimonialId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
