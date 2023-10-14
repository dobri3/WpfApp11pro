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
using WpfApp11pro.Core;
using WpfApp11pro.View.Pages;
using System.Windows.Media.Animation;
using System.Data.Common;

namespace WpfApp11pro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainCore.MainFrameCore = MainFrame;
            MainFrame.Navigate(new Page1());

            
        }

        


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page1());
        }

        private void Mono1_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page2());
        }

        private void ButtonMain_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page3());
        }

        private void ButtonAdd_Click_1(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page4());
        }
    }
}
