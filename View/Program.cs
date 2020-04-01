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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //User user1 = new User("10");

            /*User user3 = new User()
            {
                Name = "bram Bos",
                Email = "BramBos27@gmail.com",
                UserId = "1"
            };

            User user4 = new User()
            {
                Name = "Soo Young",
                Email = "test@email.com",
                UserId = "2"
            };

            User user = new User() {
                Id = new ObjectId("5e73ec82f90ddd05b4cd074e")
            };

            var update = Builders<BsonDocument>.Update.Set("Name", "TEST 2");
            User.updateDocument("Users", user.get().toBsonDocument(), update);*/


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
