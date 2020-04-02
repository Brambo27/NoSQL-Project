using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Model;
using System.Collections.Generic;
using MongoDB.Driver;
using System;
using System.Collections;

namespace Model
{
    public class User : Model
    {
        public enum UserType
        {
            User,
            Employee,
            Admin
        }

        public override string primaryKey { get => null; }
        public override ObjectId Id { get => id; set => id = value; }
        public override string CollectionName { get => "Users"; }

        public string userId;
        public string name;
        public string email;
        public string phoneNumber;
        public string password;
        public UserType type;
        private ObjectId id;

        public User(string user_Id, string name, string email,string password)
        {
            userId = user_Id;
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public User(string user_Id)
        {
            var user = getById(primaryKey, user_Id);

            if (user != null)
            {
                this.name = user.Name;
                this.email = user.Email;
            }
        }

        public User(ObjectId id)
        {
            var user = GetByObjectId<User>(id);

            if (user != null)
            {
                this.name = user.name;
                this.email = user.email;
                this.userId = user.userId;
                this.password = user.password;
            }
        }

        public User()
        {

        }

        public static List<User> getAll()
        {
            return getAll<User>("Users");
        }

        public override dynamic deserialize(BsonDocument document)
        {
            return BsonSerializer.Deserialize<User>(document);
        }
    }
}
