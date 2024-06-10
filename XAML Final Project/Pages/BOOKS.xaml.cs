using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XAML_Final_Project.Pages
{
    /// <summary>
    /// Interaction logic for BOOKS.xaml
    /// </summary>
    public partial class BOOKS : Page
    {
        public BOOKS()
        {
            InitializeComponent();
        }
    }

    class Books
    {
        public Books()
        {

        }
        public List<Books> ReadingBooks { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public string Book { get; set; }
        public string Availability { get; set; }

    }
}
