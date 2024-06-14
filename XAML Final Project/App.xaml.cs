using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using XAML_Final_Project.Utilities;

namespace XAML_Final_Project
{

    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            DatabaseConnect.EstablishConnection("XAML_Database");
            onSplashStart();
        }


        private void onSplashStart()
        {
            Debug.WriteLine("GO!");

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Interval = 3000;
            aTimer.Elapsed += new ElapsedEventHandler(OnTick);
            aTimer.Start();

            DateTime today = DateTime.Now;
            Debug.WriteLine(today.Date.TimeOfDay);
        }


        private static void OnTick(object? source, ElapsedEventArgs? e)
        {
            System.Timers.Timer t = source as System.Timers.Timer;
            t.Stop();
            t.Dispose();

          
           MainWindow mw= new MainWindow();
            mw.Show();
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
