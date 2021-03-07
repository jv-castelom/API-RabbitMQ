using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Models.Entities
{
    public class Entity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
    }
}
