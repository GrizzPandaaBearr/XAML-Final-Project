using System;
using System.Collections.Generic;
using System.Data.Common;
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


namespace XAML_Final_Project.Component
{
    public partial class LogIn_Screen : UserControl
    {
        public LogIn_Screen()
        {
            InitializeComponent();
        }

        private static Frame GetApplicationLoginFrame()
        {
            MainWindow w = (MainWindow)Application.Current.MainWindow;
            Frame f = (Frame)w.LoginFrame;
            return f;
        }

        private void OnLogInClicked(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            DatabaseConnect.ListTheCollections();

            if (DatabaseConnect.AuthenticateUser(email, password))
            {
                MessageBox.Show("Login successful!");
                GetApplicationLoginFrame().Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Invalid Username or password. Please try again.");
            }

        }

        private void OnAdminClicked(object sender, RoutedEventArgs e)
        {
            GetApplicationLoginFrame().Visibility = Visibility.Hidden;
        }
     }
}
