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

namespace Rsteam.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageMenuMain.xaml
    /// </summary>
    public partial class PageMenuMain : Page
    {
        public PageMenuMain()
        {
            InitializeComponent();
            MainNavigationFrame.NavigationService.Navigate(new PageShouBlocGames());
        }

        private void ClEventAddGame(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddGame());
        }

        private void ClEventDellGame(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageDellGame());
        }

        private void ClEventChangGame(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageShowGameFoEdit());
        }

        private void ClEventBlockGameShow(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageShouBlocGames());
        }

        private void ClEventEditAkk(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageEditAkk());
        }
    }
}
