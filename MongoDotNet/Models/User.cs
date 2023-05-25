using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace MongoDotNet.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Id")]
        public string Id { get; set; }
        [BsonElement("Gender")]
        public string Gender { get; set; }
        [BsonElement("Name")]
        [JsonPropertyName("Name")]
        public List<string> Name { get; set; }
        [BsonElement("Location")]
        public List<string> Location { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Login")]
        public List<string> Login { get; set; }
        [BsonElement("Dob")]
        public List<string> Dob { get; set; }
        [BsonElement("Registered")]
        public List<string> Registered { get; set; }
        [BsonElement("Phone")]
        public string Phone { get; set; }
        [BsonElement("Picture")]
        public List<string> Ids { get; set; }
        [BsonElement("Picture")]
        public List<string> Picture { get; set; }
        [BsonElement("Nat")]
        public string Nat { get; set; }
    }
}
