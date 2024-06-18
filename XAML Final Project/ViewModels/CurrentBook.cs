using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML_Final_Project.ViewModels
{
    public class CurrentBook
    {
        private string bookID;

        public string BookID
        {
            get { Debug.WriteLine($"Book GET to {bookID}"); return bookID; }
            set { Debug.WriteLine($"Book SET to {value}"); bookID = value; }
        }


        public CurrentBook()
        {

            BookID = String.Empty;
            Debug.WriteLine($"CurrentBook {BookID}");
        }
    }
}
