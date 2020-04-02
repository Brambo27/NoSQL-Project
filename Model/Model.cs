using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections;
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

        public static void insertIntoCollection(string collection, BsonDocument data)
        {
            insertIntoCollection(getCollection(collection), data);
        }

        public static void insertIntoCollection(string collection, BsonDocument[] data)
        {
            insertIntoCollection(getCollection(collection), data);
        }

        public void insertIntoCollection(IMongoCollection<BsonDocument> collection)
        {
            insertIntoCollection(collection, this.ToBsonDocument());
        }

        public void insertIntoCollection(string collection)
        {
            insertIntoCollection(getCollection(collection), this.ToBsonDocument());
        }

        public void insertIntoCollection()
        {
            insertIntoCollection(getCollection(CollectionName), this.ToBsonDocument());
        }

        public static void updateDocument(string collection, BsonDocument document, UpdateDefinition<BsonDocument> update)
        {
            getCollection(collection).UpdateOne(document, update);
        }

        public void update()
        {
            BsonDocument originalDocument = GetByObjectId(Id);
            BsonDocument updateDocument = this.ToBsonDocument();

            getCollection(CollectionName).ReplaceOne(originalDocument, updateDocument);
        }

        public BsonDocument SelectWhere(FilterDefinition<BsonDocument> filter)
        {
            return getCollection(CollectionName).Find(filter).FirstOrDefault();
        }

        public BsonDocument GetByObjectId(ObjectId objectId)
        {
            return getCollection(CollectionName).Find(new BsonDocument { { "_id", objectId } }).First();
        }

        public T GetByObjectId<T>(ObjectId objectId)
        {
            return BsonSerializer.Deserialize<T>(getCollection(CollectionName).Find(new BsonDocument { { "_id", objectId } }).First());
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
            return getById(field, value, CollectionName);
        }

        public abstract dynamic deserialize(BsonDocument document);

        public dynamic deserialize<T>(BsonDocument document)
        {
            return BsonSerializer.Deserialize<T>(document);
        }

        public static List<T> getAll<T>(string collectionName)
        {
            var documents = getCollection(collectionName).Find(new BsonDocument()).ToList();

            List<T> objects = new List<T>();
            foreach (BsonDocument document in documents)
            {
                objects.Add(BsonSerializer.Deserialize<T>(document));
            }

            return objects;
        }

        public virtual List<T> getAll<T>()
        {
            return getAll<T>(CollectionName);
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
