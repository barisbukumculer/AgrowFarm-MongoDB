using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarm_MongoDB.Entities
{
    public class About
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string AboutId { get; set; }
        public string Title { get; set; }
        public string Service1 { get; set; }
        public string Service2 { get; set; }
        public string Service3 { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string Description { get; set; }

    }
}
