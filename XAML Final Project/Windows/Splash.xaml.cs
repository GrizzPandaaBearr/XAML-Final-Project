using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows;



namespace XAML_Final_Project.Windows
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Window
    {


        public Splash()
        {
            InitializeComponent();
        }

        private void OnContentRendered(object sender, EventArgs e)
        {

            System.Timers.Timer aTimer = new(500);
            aTimer.Elapsed += new ElapsedEventHandler(OnTick);
            aTimer.Start();
        }



        private void OnTick(object? source, ElapsedEventArgs? e)
        {

            System.Timers.Timer? t = source as System.Timers.Timer;

            if (t != null)
            {

                Die();
                t.Stop();
                t.Dispose();
                GC.Collect();
            }



        }


        private void Die()
        {
            //windows are on separate thread, can't just close them from within
            // this.Close();

            Application.Current.Dispatcher.BeginInvoke(new Action(Close));



        }
    }
}
