using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WhatsApp.Commands;
using WhatsApp.Views;

namespace WhatsApp.ViewModels
{
    internal class RegisterOrLoginViewModel
    {
        public ICommand? LoginCommand { get; set; }
        public ICommand? RegisterCommand { get; set; }

        public RegisterOrLoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
        }

        public void Login(object? parameter)
        {
            MainFrame.Navigate(new Login());
        }
    }
}
