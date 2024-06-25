using System.Windows;
using XAML_Final_Project.Utilities;
using XAML_Final_Project.Windows;

namespace XAML_Final_Project
{

    public partial class App : Application
    {
        private Splash? SplashScreen;

        private void Application_Startup(object sender, StartupEventArgs e)
        {

            //ShowSplashScreen();
            DatabaseConnect.EstablishConnection("XAML_Database");

        }

        private void ShowSplashScreen()
        {
            SplashScreen = new Splash();
            SplashScreen.Owner = Application.Current.MainWindow as MainWindow;
            SplashScreen.Show();
        }



        private void Application_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

            //List<int> myArray = new List<int> { 99, 8, 6, 7, };
            //myArray.Add(666);
            //IEnumerator<int> myEnumrableInts = myArray.GetEnumerator();

            //ArrayList myList = new ArrayList();



            //while (myEnumrableInts.MoveNext())
            //{
            //    Debug.WriteLine(myEnumrableInts.Current);
            //}



        }
    }
}
