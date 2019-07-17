using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using WebApplication3.Services;

namespace WebApplication3.Models
{
    [BsonIgnoreExtraElements]
    public class ContactForm : EntityNDTF
    {
        [BsonElement("fullname")]
        public string Fullname { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("subject")]
        public string Subject { get; set; }
        [BsonElement("message")]
        public string Message { get; set; }
        [BsonElement("hasResponse")]
        public bool hasResponse { get; set; }

    }
}
