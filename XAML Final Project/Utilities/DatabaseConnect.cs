
using MongoDB;
using System.Windows;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Collections;

namespace XAML_Final_Project.Utilities
{
    public class DatabaseConnect
    {

        private const string connectionUri = "mongodb+srv://Grizzpandaabearr:8899GMK-gmk@grizzpandaabearr.cdd1the.mongodb.net/?retryWrites=true&w=majority&appName=Grizzpandaabearr";
        private static MongoClient? _client;
        public static MongoDatabaseBase? _database;


        public static void EstablishConnection(string DB_Name)
        {


            _client = new MongoClient(connectionUri);
            _database = _client.GetDatabase(DB_Name) as MongoDatabaseBase;


            // debug only, can we successfuly ping our DB, response from Mongo is Bson not Json
            //if (_database != null)
            // {
            //     BsonDocument isOK = _database.RunCommand<BsonDocument>(new BsonDocument("ping", 1));
            //     BsonValue result = isOK.GetElement("ok").Value;
            //     Debug.WriteLine(result.ToString());
            // } else {
            //     _database = null;
            //     MessageBox.Show($"Problem connecting to database, {DB_Name}."); 
            // }

        }

        public static void ListTheCollections()
        {
            if (DatabaseConnect._database != null)
            {
                var collections = DatabaseConnect._database.ListCollectionNames().ToList();
                foreach (string c in collections)
                {
                    Debug.WriteLine(c);
                }
            }


        }
    }
}
