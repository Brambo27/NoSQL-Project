using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UserManagementController
    {
        Model.UserManagementModel db = new Model.UserManagementModel();



        public void addUser(List<dynamic> data)
        {
            UserManagementModel user = new UserManagementModel();
            user.FirstName = data[0];
            user.LastName = data[1];
            user.UserType = data[2];
            user.Email = data[3];
            user.PhoneNumber = data[4];
            user.Location = data[5];

            Model.Model.insertIntoCollection(db.CollectionName, Model.Model.toBsonDocumentArray(data));
        }

        public List<dynamic> getUsers()
        {
            return Model.Model.getAll(db.CollectionName);
        }
    }
}
