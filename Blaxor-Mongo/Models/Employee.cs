using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blaxor_Mongo.Models
{
    public class Employee
    {
        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public object Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
