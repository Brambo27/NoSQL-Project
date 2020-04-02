using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace View
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //User user1 = new User("10");

            User user3 = new User()
            {
                Name = "bram Bos",
                Email = "BramBos27@gmail.com",
                UserId = "1",
                Password = "bram123"
            };

            User user4 = new User()
            {
                Name = "Soo Young",
                Email = "test@email.com",
                UserId = "2",
                Password = "test123"
            };

            User user = new User() {
                Id = new ObjectId("5e73ec82f90ddd05b4cd074e")
            };

            var update = Builders<BsonDocument>.Update.Set("Name", "TEST 2");
            //User.updateDocument("Users", user.toBsonDocument(), update);
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("UserId", 5);
            //Model.Model.deleteDocument("Users", deleteFilter);
            
            //Application.Run(new Login());


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
