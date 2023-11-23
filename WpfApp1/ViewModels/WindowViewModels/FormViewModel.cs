using WpfApp1.Helpers;
using WpfApp1.Views.Pages;

namespace WpfApp1.ViewModels.WindowViewModels
{
    public class FormViewModel : Notifier
    {

        public Navigation Navigation { get; set; }

        public FormViewModel(Navigation navigation)
        {
            Navigation = navigation;

            Navigation.Frame.Content = new RegistrationView();
            Navigation.Frame.Opacity = 1;
        }
    }
}
