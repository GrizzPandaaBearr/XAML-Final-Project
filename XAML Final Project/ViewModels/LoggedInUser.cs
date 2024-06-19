
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XAML_Final_Project.Commands;

namespace XAML_Final_Project.ViewModels
{
    public class LoggedInUser : INotifyPropertyChanged
    {
        public bool LoggedInStatus { get; set; }
        public ICommand LogOutCommand { get; }


        public LoggedInUser()
        {
            LoggedInStatus = true;
            LogOutCommand = new LogOutCommand(this);

        }

        public void LogOut()
        {
            LoggedInStatus = !LoggedInStatus;
            BroadcastPropertyUpdated(nameof(LoggedInStatus));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void BroadcastPropertyUpdated(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}