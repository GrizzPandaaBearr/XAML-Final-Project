using MongoDB;
using System.Windows;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Collections;
using System.Linq;

public class DatabaseConnect
{
    //
    private const string connectionUri = "mongodb+srv://Grizzpandaabearr:8899GMK-gmk@grizzpandaabearr.cdd1the.mongodb.net/?retryWrites=true&w=majority&appName=Grizzpandaabearr";
    private static MongoClient? _client;
    public static MongoDatabaseBase? _database;

    public static void EstablishConnection(string DB_Name)
    {
        _client = new MongoClient(connectionUri);
        _database = _client.GetDatabase(DB_Name) as MongoDatabaseBase;
    }

    public static void ListTheCollections()
    {
        if (_database != null)
        {
            var collections = _database.ListCollectionNames().ToList();
            foreach (string c in collections)
            {
                Debug.WriteLine(c);
            }
        }
    }

    public static void InsertDocument<T>(string collectionName, T document)
    {
        if (_database != null)
        {
            var collection = _database.GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }
    }

    public static ArrayList GetDocuments<T>(string collectionName)
    {
        ArrayList documents = new ArrayList();
        if (_database != null)
        {
            var collection = _database.GetCollection<T>(collectionName);
            documents.AddRange(collection.Find(new BsonDocument()).ToList());
        }
        return documents;
    }

    public static void UpdateDocument<T>(string collectionName, FilterDefinition<T> filter, UpdateDefinition<T> update)
    {
        if (_database != null)
        {
            var collection = _database.GetCollection<T>(collectionName);
            collection.UpdateOne(filter, update);
        }
    }

    public static void DeleteDocument<T>(string collectionName, FilterDefinition<T> filter)
    {
        if (_database != null)
        {
            var collection = _database.GetCollection<T>(collectionName);
            collection.DeleteOne(filter);
        }
    }

    public static bool AuthenticateUser(string username, string password)
    {
        if (_database != null)
        {
            var collection = _database.GetCollection<BsonDocument>("members");
            var filter = Builders<BsonDocument>.Filter.Eq("username", username) & Builders<BsonDocument>.Filter.Eq("password", password);
            var user = collection.Find(filter).FirstOrDefault();

            return user != null;
        }
        return false;
    }
}