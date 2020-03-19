using Model;
using MongoDB.Bson;
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
                UserId = "1"
            };

            User user4 = new User()
            {
                Name = "Soo Young",
                Email = "test@email.com",
                UserId = "2"
            };

            User user5 = new User();
           
            user5.Id = new ObjectId("5e73b428f90ddd4604f2e45a");
            user5 = user5.get();


            List<dynamic> users = new List<dynamic>();
            users.Add(user3);
            users.Add(user4);

            users = User.getAll();

            users = Model.Model.getAll("Users");

            //Model.Model.insertIntoCollection(Model.Model.getCollection("Users"), Model.Model.toBsonDocumentArray(users));

            Console.WriteLine("User5: " + user5.Name);


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
