using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarm_MongoDB.Entities
{
    public class VideoBanner
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string VideoBannerId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Descripton { get; set; }
        public string? VideoUrl { get; set; }
    }
}
