using System;
using System.Collections.Generic;
using System.Text;
using Core.Models.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Data
{
    public class MongoAcess
    {
        public const string CONNECTION_STRING = "mongodb://localhost:27017";
        public const string DATABASE = "AT_API";
        public const string COLLECTION = "Customers";
        public static IMongoClient _client { get; }
        public static IMongoDatabase _database { get; }

        static MongoAcess()
        {
            _client = new MongoClient(CONNECTION_STRING);
            _database = _client.GetDatabase(DATABASE);
        }

        public IMongoCollection<Customer> Customers
        {
            get { return _database.GetCollection<Customer>(COLLECTION); }
        }
    }
}
