using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Model
{
    public abstract class Model
    {
        protected abstract string PrimaryKey { get; }
        protected abstract string CollectionName { get; }
        public abstract ObjectId Id { get; set; }

        private static IMongoDatabase GetDatabase()
        {
            var client =
                new MongoClient(
                    "mongodb+srv://dbUser:Pret9999@cluster0-iiugx.azure.mongodb.net/test?retryWrites=true&w=majority");
            return client.GetDatabase("NOSQL");
        }

        private static IMongoCollection<BsonDocument> getCollection(string collectionName)
        {
            return GetDatabase().GetCollection<BsonDocument>(collectionName);
        }

        public IMongoCollection<BsonDocument> getCollection()
        {
            return GetDatabase().GetCollection<BsonDocument>(CollectionName);
        }

        public static void insertIntoCollection(IMongoCollection<BsonDocument> collection, BsonDocument[] data)
        {
            if (data != null) collection.InsertMany(data);
        }

        public static void insertIntoCollection(IMongoCollection<BsonDocument> collection, BsonDocument data)
        {
            if (data != null) collection.InsertOne(data);
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

        public static void updateDocument(string collection, BsonDocument document,
            UpdateDefinition<BsonDocument> update)
        {
            getCollection(collection).UpdateOne(document, update);
        }

        public void update()
        {
            var originalDocument = GetByObjectId(Id);
            var updateDocument = this.ToBsonDocument();

            getCollection(CollectionName).ReplaceOne(originalDocument, updateDocument);
        }

        public BsonDocument SelectWhere(FilterDefinition<BsonDocument> filter)
        {
            return getCollection(CollectionName).Find(filter).FirstOrDefault();
        }


        public T SelectWhere<T>(FilterDefinition<BsonDocument> filter)
        {
            T item = default;
            try
            {
                item = BsonSerializer.Deserialize<T>(getCollection(CollectionName).Find(filter).FirstOrDefault());
            }
            catch (ArgumentNullException e)
            {
                if (e.InnerException is ArgumentNullException)
                    Console.WriteLine(e.Message);
                else
                    Console.WriteLine(e.Message);
            }

            return item;
        }

        public static List<T> selectAllWhere<T>(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            var documents = getCollection(collectionName).Find(filter).ToList();

            var objects = new List<T>();
            foreach (var document in documents) objects.Add(BsonSerializer.Deserialize<T>(document));

            return objects;
        }

        public static void deleteDocument(string collection, FilterDefinition<BsonDocument> filter)
        {
            getCollection(collection).DeleteOne(filter);
        }

        public BsonDocument GetByObjectId(ObjectId objectId)
        {
            return getCollection(CollectionName).Find(new BsonDocument {{"_id", objectId}}).First();
        }

        public T GetByObjectId<T>(ObjectId objectId)
        {
            return BsonSerializer.Deserialize<T>(getCollection(CollectionName)
                .Find(new BsonDocument {{"_id", objectId}}).First());
        }

        public dynamic getById(string field, string value, string collectionName)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(field, value);

            var document = getCollection(collectionName).Find(filter).FirstOrDefault();
            if (document != null)
            {
                var dynamic = deserialize(document);

                return dynamic;
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

            var objects = new List<T>();
            foreach (var document in documents) objects.Add(BsonSerializer.Deserialize<T>(document));

            return objects;
        }

        private static List<BsonDocument> GetAllDocuments(string collectionName)
        {
            return getCollection(collectionName).Find(new BsonDocument()).ToList();
        }

        public dynamic get()
        {
            FilterDefinition<BsonDocument> filter;

            if (PrimaryKey == null)
                filter = Builders<BsonDocument>.Filter.Eq("_id", Id);
            else
                filter = Builders<BsonDocument>.Filter.Eq(PrimaryKey, Id);


            var document = getCollection("Users").Find(filter).FirstOrDefault();

            if (document != null)
            {
                var ding = deserialize(document);

                return ding;
            }

            return null;
        }

        public static BsonDocument[] toBsonDocumentArray(List<dynamic> dynamics)
        {
            var documents = new List<BsonDocument>();

            foreach (var thing in dynamics) documents.Add(thing.toBsonDocument());

            return documents.ToArray();
        }

        public static void BackupDocuments(string backupLocation, string collection)
        {
            var documents = GetAllDocuments(collection) ?? throw new ArgumentNullException("No documents found.");

            //open file stream
            using (var file = File.CreateText(backupLocation + "/" + collection + "_backup.txt"))
            {
                file.WriteLine("{\"collectionName\": \"" + collection + "\"}");
                var serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, documents.ConvertAll(BsonTypeMapper.MapToDotNetValue));
            }
        }

        public static void InsertFromBackup(string backupLocation)
        {
            using (var r = new StreamReader(backupLocation))
            {
                // Type type = Type.GetType("Model." + collection.Remove(collection.Length - 1));
                // JArray json = JArray.Parse(r.ReadToEnd());
                //List<dynamic> items = JsonConvert.DeserializeObject<List<dynamic>>(json);

                //The first line of the backup file has info about the collection we're supposed to restore.
                var collectionJson = r.ReadLine();
                dynamic collectionNameJson = JObject.Parse(collectionJson);
                string collectionName = collectionNameJson.collectionName;

                //Read the rest of the backup file.
                var json = r.ReadToEnd();

                //We kunnen alleen de backup terug zetten als de database leeg is in verband met duplicate keys,
                //Dus check of de database leeg is.
                if (getCollection(collectionName).Find("{}").CountDocuments() == 0)
                    //Dit was erg mooi geweest maar helaas. Het mocht niet zo zijn.
                    // BsonSerializer.Deserialize<List<User>>(json).ForEach(dynamic => dynamic.insertIntoCollection());

                    try
                    {
                        //Get the first row so we can check what type the model should be.
                        var typeString = JArray.Parse(json).First()["_t"].ToString();
                        var type = Type.GetType("System.Collections.Generic.List`1[Model." + typeString + "]");
                        var deserializedJsonList = (IList) BsonSerializer.Deserialize(json, type);

                        foreach (Model item in deserializedJsonList) item.insertIntoCollection(collectionName);
                    }
                    catch (Exception e)
                    {
                        //Er kan een hoop fout gaan in deze functie dus als er iets fout gaat geef ik gewoon de gebruiker de schuld.
                        throw new Exception("Backup file has possibly been corrupted. Please don't try again.");
                    }
                else
                    throw new Exception("Database is not empty. Database needs to be empty to insert from backup");
            }
        }

        public static List<string> getAllCollectionNames()
        {
            var collections = new List<string>();

            foreach (var collection in GetDatabase().ListCollectionsAsync().Result.ToListAsync().Result)
            {
                var name = collection["name"].AsString;
                collections.Add(name);
            }

            return collections;
        }
    }
}