using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Model;
using System.Collections.Generic;
using MongoDB.Driver;

namespace Model
{
    public class User : Model
    {
        ObjectId _id;
        public override string primaryKey { get => null; }
        public override ObjectId Id { get => _id; set => _id = value; }
        public override string CollectionName { get => "Users"; }

        public string UserId;
        public string Name;
        public string Email;

        public static List<dynamic> getAll()
        {
            return getAll("Users");
        }

        public User(string user_Id, string name, string email)
        {
            UserId = user_Id;
            Name = name;
            Email = email;
        }

        public User(string user_Id)
        {
            var user = getById(primaryKey, user_Id);

            if (user != null)
            {
                this.Name = user.Name;
                this.Email = user.Email;
            }
        }

        public User()
        {

        }

        public override dynamic deserialize(BsonDocument document)
        {
            return BsonSerializer.Deserialize<User>(document);
        }
    }
}
