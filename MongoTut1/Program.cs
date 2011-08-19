using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoTut1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MongoServer server = MongoServer.Create();
            MongoDatabase database = server.GetDatabase("books");
            MongoCollection<BsonDocument> books =
                database.GetCollection<BsonDocument>("books");
            BsonDocument[] batch = {
    new BsonDocument {
        { "author", "Kurt Vonnegut" },
        { "title", "Cat's Cradle" }
    },
    new BsonDocument {
        { "author", "Kurt Vonnegut" },
        { "title", "Slaughterhouse-Five" }
    }
};
            books.InsertBatch(batch);

        }
    }
}