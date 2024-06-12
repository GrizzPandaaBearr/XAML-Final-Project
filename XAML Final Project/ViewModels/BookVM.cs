using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Input;
using XAML_Final_Project.Models;
using XAML_Final_Project.Pages;
using XAML_Final_Project.Utilities;

namespace XAML_Final_Project.ViewModels
{
    public class BookVM
    {
        public List<BookDTO> BooksCollectionList { get; set; }
        public IEnumerable<BookDTO> BooksCollectionAsEnumerable => BooksCollectionList;

        private readonly IMongoCollection<BookDTO>? DB_Results;


        public BookVM()
        {
            IMongoDatabase? db = DatabaseConnect._database;
            //DatabaseConnect.ListTheCollections();



            if (db != null)
            {


                BsonDocument filter = new BsonDocument();
                filter.Add("Author", "George Orwell");



                IMongoCollection<BookDTO> DB_Results = db.GetCollection<BookDTO>("all_books");
                //GetCollectionCount(DB_Results);
                BooksCollectionList = DB_Results.Find(filter).SortBy(x => x.Name).ToList();




            }


        }

        private void GetCollectionCount(IMongoCollection<BookDTO> c)
        {
            var resultsCount = c.CountDocuments(new BsonDocument());
            MessageBox.Show($"Geeting Books Collection = {resultsCount}");
        }
    }
}
