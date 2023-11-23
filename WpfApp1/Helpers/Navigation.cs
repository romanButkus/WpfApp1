using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WpfApp1.Helpers
{
    public class Navigation
    {
        public Frame Frame { get; set; }

        public Navigation()
        {
            Frame = new Frame();
        }

        public async void ChangePage(Page page)
        {
            DoubleAnimation hide = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
            Frame.BeginAnimation(UIElement.OpacityProperty, hide);

            await Task.Delay(TimeSpan.FromSeconds(0.5));

            Frame.Content = page;

            DoubleAnimation show = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
            Frame.BeginAnimation(UIElement.OpacityProperty, show);
        }
    }
}
