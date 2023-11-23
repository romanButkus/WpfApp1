using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для FormView.xaml
    /// </summary>
    public partial class FormView : Window
    {

        public FormView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainBackground.Width = this.Width;

            var time = TimeSpan.FromSeconds(1);

            DoubleAnimation closeAnimation = new DoubleAnimation(MainBackground.Width, 0, time);

            closeAnimation.EasingFunction = new CircleEase() { EasingMode = EasingMode.EaseOut};


            closeAnimation.Completed += (s, _e) => App.Current.Shutdown();
            
            MainBackground.BeginAnimation(WidthProperty, closeAnimation);
        }

        private async void MaximizeButton_Click_1(object sender, RoutedEventArgs e)
        {
            var time = TimeSpan.FromSeconds(0.3);

            DoubleAnimation maximizeAnimation = new DoubleAnimation(1, 0, time);

            maximizeAnimation.Completed += (s, _e) => WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;

            MainBackground.BeginAnimation(UIElement.OpacityProperty, maximizeAnimation);

            await Task.Delay(time);

            DoubleAnimation normilizeAnimation = new DoubleAnimation(0, 1, time);

            MainBackground.BeginAnimation(UIElement.OpacityProperty, normilizeAnimation);
        }
        
        private void MinimizeButton_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
