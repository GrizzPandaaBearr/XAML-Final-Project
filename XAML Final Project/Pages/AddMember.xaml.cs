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
    public partial class AddMember : Page
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMemberButton_Click(object sender, RoutedEventArgs e)
        {
            var userName = FullNameTextBox.Text;
            var passWord = CustomerNumberTextBox.Text;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
            {
                var newMember = new Member
                {
                    Username = userName,
                    Password = passWord
                };

                DatabaseConnect.InsertDocument("members", newMember);

                MessageBox.Show("Member added successfully!");
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
    }

    public class Member
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}