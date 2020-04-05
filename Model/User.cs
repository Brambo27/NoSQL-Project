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

        public override string primaryKey { get => "userId"; }
        public override ObjectId Id { get => id; set => id = value; }
        public override string CollectionName { get => "Users"; }

        public string userId;
        public string name;
        public string email;
        public string password;
        public UserType userType;
        public string phoneNumber;
        public string location;
        public string firstName;
        public string lastName;
        public string tickets;
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
                this.Id = user.Id;
                this.name = user.name;
                this.email = user.email;
                this.userId = user.userId;
                this.phoneNumber = user.phoneNumber;
                this.password = user.password;
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

       public static void GenerateRandom()
        {
            Random rand = new Random(); // we need a random variable to select names randomly

            RandomName nameGen = new RandomName(rand); // create a new instance of the RandomName class

            string[] email = { "gmail.com", "hotmail.com", "yahoo.com", "student.inholland.nl", "hotmale.com" };

            List<string> names = nameGen.RandomNames(100, 0);
            for (int i = 0; i < 100; i++)
            {
                User user = new User()
                {
                    name = names[i],
                    email = names[i].Replace(" ", "") + "@" + email[rand.Next(email.Length)],
                    password = Auth.encryptPassword(names[i].Replace(" ", "") + rand.Next(1000, 99999).ToString()),
                    userId = (i + 1).ToString(),
                    phoneNumber = rand.Next(100000000, 999999999).ToString(),
                };

                user.insertIntoCollection();
            }
        }
    }
}
