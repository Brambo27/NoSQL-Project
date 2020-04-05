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



            //Random rand = new Random(); // we need a random variable to select names randomly

            //RandomName nameGen = new RandomName(rand); // create a new instance of the RandomName class

            //string[] email = { "gmail.com", "hotmail.com", "yahoo.com", "student.inholland.nl", "hotmale.com" };

            //List<string> names = nameGen.RandomNames(100, 0);
            //    for (int i = 0; i < 100; i++)
            //    {

            //        User user = new User()
            //        {
            //            name = names[i],
            //            email = names[i].Replace(" ", "") + "@" + email[rand.Next(0, 4)],
            //            password = names[i].Replace(" ", "") + rand.Next(1000, 99999).ToString(),
            //            userId = (i + 1).ToString(),
            //            phoneNumber = rand.Next(100000000, 999999999).ToString(),
            //        };

            //        user.insertIntoCollection();
            //    }

            //Application.Run(new Login());
            //var deleteFilter = Builders<BsonDocument>.Filter.Eq("IncidentID", "1");
            //Model.Model.deleteDocument("Users", deleteFilter);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            User u = new User();
            Application.Run(new Dashboard(u));
            
          
        }
    }
}
