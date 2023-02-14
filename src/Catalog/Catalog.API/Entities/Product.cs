using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string? Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("catagory")]
        public string Catagory { get; set; }
        [BsonElement("summary")]
        public string Summary { get; set; }
        [BsonElement("price")]
        public decimal Price { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("image-file")]
        public string ImageFile { get; set; }
    }
}
