using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Attributes;
using WebApplication3.Services;

namespace WebApplication3.Models
{
    [BsonIgnoreExtraElements]
    public class NewsletterForm : EntityNDTF
    {
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("firstname")]
        public string Firstname { get; set; }
        [BsonElement("lastname")]
        public string Lastname { get; set; }
        [BsonElement("isCancelled")]
        public bool isCancelled { get; set; }
    }
}
