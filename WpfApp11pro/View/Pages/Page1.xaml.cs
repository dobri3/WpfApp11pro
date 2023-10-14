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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp11pro.Core;

namespace WpfApp11pro.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            DoubleAnimation btnAnimation = new DoubleAnimation();
            btnAnimation.From = 0;
            btnAnimation.To = 300;
            btnAnimation.Duration = TimeSpan.FromSeconds(2);

            dopbtn.BeginAnimation(Button.WidthProperty, btnAnimation);  
        }

        private void ButtonMain_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page3());
        }

        private void ButtonAdd_Click_1(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page4());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page1());
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMonok_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page2());
        }
    }
}
