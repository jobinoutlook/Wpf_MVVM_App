using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wpf_MVVM_App.Commands;
using Wpf_MVVM_App.Models;
using Wpf_MVVM_App.Views;

namespace Wpf_MVVM_App.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }


        public ICommand ShowWindowCommand { get; set; }

        public ICommand ShowTextCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);

            ShowTextCommand = new RelayCommand(ShowTxtWindow, CanShowWindow);

        }

        

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = (Window)obj;

            AddUser addUserWin = new AddUser();
            addUserWin.Owner = mainWindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }

        private void ShowTxtWindow(object obj)
        {
            ShowText showText=new ShowText();
            showText.Show();
        }
    }
}
