using System.Windows.Input;
using WpfApp1.Helpers;
using WpfApp1.Views.Pages;
using WpfApp1.Views.Windows;

namespace WpfApp1.ViewModels.PageViewModels
{
    public class AuthorizationViewModel : Notifier
    {
        private readonly Navigation _navigation;

        public AuthorizationViewModel(Navigation navigation)
        {
            _navigation = navigation;
        }
    

        public ICommand GoToRegistrationPageCommand => new Command(x => _navigation.ChangePage(new RegistrationView()));
    }
}
