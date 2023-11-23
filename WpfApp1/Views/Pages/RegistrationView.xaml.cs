using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : Page
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if(UserName == null || Surname == null || Phonenumber == null || Email == null || Password == null || PasswordReset == null) 
            {
                MessageBox.Show("You cant register!", "You didnt fill in all fields", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
