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
using Rsteam.PagesApp; 

namespace Rsteam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainNaviFrame.NavigationService.Navigate(new PageAuthrization());
        }

        private void DownDravWindows(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ClEventExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClEventInVize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

     

        private void ClEventLogOut(object sender, RoutedEventArgs e)
        {
            MainNaviFrame.NavigationService.Navigate(new PageAuthrization());
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }
    }
}
