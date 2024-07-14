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

namespace XAML_Final_Project.Component
{
    public partial class MainMenu_Admin : Page
    {
        public MainMenu_Admin()
        {
            InitializeComponent();
        }

        private static Frame GetApplicationMainFrame()
        {
            MainWindow w = (MainWindow)Application.Current.MainWindow;
            Frame f = (Frame)w.MainAppFrame;
            return f;
        }

        private void View_All_Books(object sender, RoutedEventArgs e)
        {
            GetApplicationMainFrame().NavigationService.Navigate(new Uri("/Pages/Books.xaml", UriKind.Relative));

        }
        private void AddMembersMenuItem_Click(object sender, RoutedEventArgs e)
        {
            GetApplicationMainFrame().NavigationService.Navigate(new Uri("/Pages/AddMember.xaml", UriKind.Relative));
        }
    }
}
