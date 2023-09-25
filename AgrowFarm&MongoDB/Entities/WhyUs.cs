using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarm_MongoDB.Entities
{
    public class WhyUs
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string WhyUsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CircleTitle1 { get; set; }
        public string CirclePercent1 { get; set; }
        public string CircleDescription1 { get; set; }
        public string CircleTitle2 { get; set; }
        public string CirclePercent2 { get; set; }
        public string CircleDescription2 { get; set; }
    }
}
