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
<<<<<<< HEAD
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("description", "test");
            Model.Model.deleteDocument("Incidents", deleteFilter);
=======
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

>>>>>>> cfb73121685a9d086d4194b145939bec38c27115

           User.GenerateRandom(1);

            //Application.Run(new Login());
        }
    }
}
