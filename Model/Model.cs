using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Model
{
    public abstract class Model
    {
        public abstract string primaryKey { get; }
        public abstract string CollectionName { get; }
        public abstract ObjectId Id { get; set; }

        public static IMongoDatabase GetDatabase()
        {
            MongoClient client = new MongoClient("mongodb+srv://dbUser:Pret9999@cluster0-iiugx.azure.mongodb.net/test?retryWrites=true&w=majority");
            return client.GetDatabase("NOSQL");
        }

        public static IMongoCollection<BsonDocument> getCollection(string collectionName)
        {
            return GetDatabase().GetCollection<BsonDocument>(collectionName);
        }

        public IMongoCollection<BsonDocument> getCollection()
        {
            return GetDatabase().GetCollection<BsonDocument>(CollectionName);
        }

        public static void insertIntoCollection(IMongoCollection<BsonDocument> collection, BsonDocument[] data)
        {
            if(data != null)
            {
               collection.InsertMany(data);
            }
        }

        public static void insertIntoCollection(IMongoCollection<BsonDocument> collection, BsonDocument data)
        {
            if (data != null)
            {
                collection.InsertOne(data);
            }
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

        public T SelectWhere<T>(FilterDefinition<BsonDocument> filter)
        {
            return BsonSerializer.Deserialize<T>(getCollection(CollectionName).Find(filter).FirstOrDefault());
        }

        public static List<T> selectAllWhere<T>(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            var documents = getCollection(collectionName).Find(filter).ToList();

            List<T> objects = new List<T>();
            foreach (BsonDocument document in documents)
            {
                objects.Add(BsonSerializer.Deserialize<T>(document));
            }

            return objects;
        }

        public static void deleteDocument(string collection, FilterDefinition<BsonDocument> filter)
        {
            getCollection(collection).DeleteOne(filter);
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

        public static List<BsonDocument> getAllDocuments(string collectionName)
        {
            return getCollection(collectionName).Find(new BsonDocument()).ToList();
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

        public static void BackupDocuments(string backupLocation, string collection)
        {
            List<BsonDocument> items = getAllDocuments(collection);

            //open file stream
            using (StreamWriter file = File.CreateText(backupLocation + "/" + collection + "_backup.txt"))
            {
                file.WriteLine("{\"collectionName\": \"" + collection + "\"}");
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, items.ConvertAll(BsonTypeMapper.MapToDotNetValue));
            }
        }

        public static void InsertFromBackup(string backupLocation)
        {
            using (StreamReader r = new StreamReader(backupLocation))
            {
                //Type type = Type.GetType("Model." + collection.Remove(collection.Length - 1));
                string collectionJson = r.ReadLine();
                string json = r.ReadToEnd();
                //List<dynamic> items = JsonConvert.DeserializeObject<List<dynamic>>(json);
                List<BsonDocument> items = BsonSerializer.Deserialize<List<BsonDocument>>(json);

                dynamic collectionNameJson = JObject.Parse(collectionJson);
                string collectionName = collectionNameJson.collectionName;

                if (getCollection(collectionName).Find<BsonDocument>("{}").CountDocuments() == 0)
                {
                    insertIntoCollection(getCollection(collectionName), items.ToArray());
                }
                else
                {
                    throw new Exception("Database is not empty. Database needs to be empty to insert from backup");
                }
            }
        }

        public static List<string> getAllCollectionNames()
        {
            List<string> collections = new List<string>();

            foreach (BsonDocument collection in GetDatabase().ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
            {
                string name = collection["name"].AsString;
                collections.Add(name);
            }

            return collections;
        }
    }
}
