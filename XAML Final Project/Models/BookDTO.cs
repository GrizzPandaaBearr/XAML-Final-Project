using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML_Final_Project.Models
{
    public class BookDTO
    {

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public ObjectId Id { get; }

        //data type
        [BsonRepresentation(BsonType.String)]
        [BsonElement("Name")]
        public string? name { get; set; }


        [BsonRepresentation(BsonType.String)]
        [BsonElement("Author")]
        public string? author { get; set; }

        [BsonRepresentation(BsonType.Double)]
        [BsonElement("ISBN")]
        public double? isbn { get; set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("Image")]
        public string? image { get; set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("Book")]
        public string? book { get; set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("Availability")]
        public string? availability { get; set; }



        // do we need this - only for uploading not for reading data ?
        public BookDTO(string _name, string _author, double _isbn, string _imgAsB64, string _book, string _avail)
        {
            name = _name;
            author = _author;
            isbn = _isbn;
            image = _imgAsB64;
            book = _book;
            availability = _avail;
        }
    }
}




