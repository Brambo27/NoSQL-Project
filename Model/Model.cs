﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Model
{
    public abstract class Model
    {
        public abstract string primaryKey { get; }
        public abstract string CollectionName { get; }
        public abstract ObjectId Id { get; set; }

        public static IMongoCollection<BsonDocument> getCollection(string collectionName)
        {
            MongoClient client = new MongoClient("mongodb+srv://dbUser:Pret9999@cluster0-iiugx.azure.mongodb.net/test?retryWrites=true&w=majority");
            IMongoDatabase database = client.GetDatabase("NOSQL");
            return database.GetCollection<BsonDocument>(collectionName);
        }

        public IMongoCollection<BsonDocument> getCollection()
        {
            MongoClient client = new MongoClient("mongodb+srv://dbUser:Pret9999@cluster0-iiugx.azure.mongodb.net/test?retryWrites=true&w=majority");
            IMongoDatabase database = client.GetDatabase("NOSQL");
            return database.GetCollection<BsonDocument>(CollectionName);
        }

        public static void insertIntoCollection(IMongoCollection<BsonDocument> collection, BsonDocument[] data)
        {
            collection.InsertMany(data);
        }

        public static void insertIntoCollection(IMongoCollection<BsonDocument> collection, BsonDocument data)
        {
            collection.InsertOne(data);
        }

        public void insertIntoCollection(IMongoCollection<BsonDocument> collection)
        {
            collection.InsertOne(toBsonDocument());
        }

        public BsonDocument toBsonDocument()
        {
            return this.ToBsonDocument();
        }

        public dynamic getById(string field, string value, string collectionName)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(field, value);

            BsonDocument document = getCollection(collectionName).Find(filter).FirstOrDefault();
            if (document != null)
            {
                dynamic ding = deserialize(document);

                return ding;
            }
            return null;
        }

        public dynamic getById(string field, string value)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(field, value);

            BsonDocument document = getCollection(CollectionName).Find(filter).FirstOrDefault();

            if (document != null)
            {
                dynamic ding = deserialize(document);

                return ding;
            }
            return null;
        }

        public abstract dynamic deserialize(BsonDocument document);

        public static List<dynamic> getAll(string collectionName)
        {
            var documents = getCollection(collectionName).Find(new BsonDocument()).ToList();
            List<dynamic> objects = new List<dynamic>();
            foreach (BsonDocument document in documents)
            {
                objects.Add(BsonSerializer.Deserialize<dynamic>(document));
            }

            return objects;
        }

        public dynamic get()
        {
            FilterDefinition<BsonDocument> filter;

            if (primaryKey == null)
            {
                filter = Builders<BsonDocument>.Filter.Eq("_id", Id);
            }
            else
            {
                filter = Builders<BsonDocument>.Filter.Eq(primaryKey, Id);
            }


            BsonDocument document = getCollection("Users").Find(filter).FirstOrDefault();

            if (document != null)
            {
                dynamic ding = deserialize(document);

                return ding;
            }
            return null;
        }

        public static BsonDocument[] toBsonDocumentArray(List<dynamic> dynamics)
        {
            List<BsonDocument> documents = new List<BsonDocument>();

            foreach (dynamic ding in dynamics)
            {
                documents.Add(ding.toBsonDocument());
            }

            return documents.ToArray();
        }
    }
}
