
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using XAML_Final_Project.ViewModels;
using static System.Net.WebRequestMethods;


//https://stackoverflow.com/questions/22285866/why-relaycommand 

namespace XAML_Final_Project.Commands
{
    public class LogOutCommand : ICommand
    {

        private readonly LoggedInUser vm;

        public LogOutCommand(LoggedInUser vm)
        {
            this.vm = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {

            vm.LogOut();


        }

        public event EventHandler? CanExecuteChanged
        {

            add
            {

                CommandManager.RequerySuggested += value;
            }
            remove
            {

                CommandManager.RequerySuggested -= value;
            }
        }
    }
}