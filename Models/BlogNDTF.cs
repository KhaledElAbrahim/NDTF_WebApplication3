using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Services;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApplication3.Models
{
    public class BlogNDTF : EntityNDTF
    {
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("body")]
        public string Body { get; set; }
        [BsonElement("dateSubitted")]
        public DateTime DateSubmitted { get; set; }
        [BsonElement("image")]
        public string Image { get; set; }
        [BsonElement("isActive")]
        public bool isActive { get; set; }
    }
}
