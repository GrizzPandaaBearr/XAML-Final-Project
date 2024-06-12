using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XAML_Final_Project.Models
{
    public class BookDTO
    {

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public ObjectId Id { get; set; }

        //data type
        [BsonRepresentation(BsonType.String)]
        [BsonElement("Name")]
        public string? Name { get; set; }


        [BsonRepresentation(BsonType.String)]
        [BsonElement("Author")]
        public string? Author { get; set; }

        [BsonRepresentation(BsonType.Int64)]
        [BsonElement("ISBN")]
        public Int64? Isbn { get; set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("Image")]
        public string? Image { get; set; }


        [BsonRepresentation(BsonType.String)]
        [BsonElement("Availability")]
        public string? Availability { get; set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("Book")]
        public string? Book { get; set; }




        //// do we need this - only for uploading not for reading data ?
        public BookDTO(string _name, string _author, Int64 _isbn, string _imgAsB64, string _book, string _avail)
        {
            Name = _name;
            Author = _author;
            Isbn = _isbn;
            Image = _imgAsB64;
            Book = _book;
            Availability = _avail;
        }
    }
}




