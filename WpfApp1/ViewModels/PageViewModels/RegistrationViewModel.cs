using DLL.Models;
using DLL.Repository;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using WpfApp1.Helpers;
using WpfApp1.Views.Pages;
using WpfApp1.Views.Windows;
using BOL.Services;
using System.Windows;

namespace WpfApp1.ViewModels.PageViewModels
{
    public class RegistrationViewModel : Notifier
    {
        private readonly Navigation _navigation;

        private readonly UserServices _userServices;

        public RegistrationViewModel(Navigation navigation, UserServices userServices)
        {
            _navigation = navigation;
            _userServices = userServices;
            User = new User();

        }

        public ICommand GoToAuthorizationPageCommand => new Command(x => _navigation.ChangePage(new AuthorizationView()));

        public ICommand RegistrationCommand => new Command(x => Registration());

        public User User { get; set; }

        public string RepeatPassword { get; set; }

        private void Registration()
        {
            if (string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.Surname) || string.IsNullOrEmpty(User.Phonenumber) || string.IsNullOrEmpty(User.Email))
            {
                MessageBox.Show("не все поля заоплнены");
                return;
            }

            if(string.IsNullOrEmpty(User.Password) || User.Password != RepeatPassword || string.IsNullOrEmpty(RepeatPassword))
            {
                
                MessageBox.Show("пароли не совпадают");
                return;
            }

            _userServices.Add(User);
        }

        
    }
}
