using System;
using System.Windows;
using System.Windows.Controls;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace XAML_Final_Project.Component
{


    public partial class BookCard : UserControl
    {


        public BookCard()
        {

            InitializeComponent();
        }

        private void OnCheckOutItem(object sender, RoutedEventArgs e)
        {
            string uidString = uid.Text;

            MessageBox.Show(uidString);

        }
    }
}
