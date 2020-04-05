using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Web.Security;

namespace Controller
{
    public class UserManagementController
    {
        public void addUser(List<dynamic> data)
        {
            List<User> users = Model.Model.getAll<User>("Users");
            var selectFilter = Builders<BsonDocument>.Filter.Eq("Name", data[0]);
            List<dynamic> tickets = Model.Model.selectAllWhere<dynamic>("Incidents", selectFilter);
            int userID = users.Count + 1;
            var user1 = new BsonDocument
            {
                {"UserId", userID.ToString() },
                {"FirstName", data[0] },
                {"LastName", data[1] },
                {"Name", data[0] + " " + data[1] },
                {"Password", Membership.GeneratePassword(12, 1) },
                {"UserType", data[2] },
                {"Email", data[3] },
                {"PhoneNumber", data[4] },
                {"Location", data[5] },
                {"Tickets", tickets.Count.ToString() }
            };

            Model.Model.insertIntoCollection("Users", user1);
        }

        
    }
}
