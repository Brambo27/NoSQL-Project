using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserManagementModel : Model
    {
        ObjectId _id;
        public override string primaryKey { get => null; }
        public override ObjectId Id { get => _id; set => _id = value; }
        public override string CollectionName { get => "Users"; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }

        public static List<dynamic> getUsers()
        {
            return getAll("Users");
        }
        public override dynamic deserialize(BsonDocument document)
        {
            return BsonSerializer.Deserialize<User>(document);
        }

        public UserManagementModel()
        {
           
        }
    }
}
