using MongoDB.Bson.Serialization.Attributes;

namespace WithMongoDbInDocker.Data
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Name")]
        public string? Name { get; set; }
        [BsonElement("Description")]
        public string? Description { get; set; }
        [BsonElement("Quatity")]
        public int Quatity { get; set; }
    }
}
