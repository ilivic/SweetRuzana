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
using Vizard.ADOApp;

namespace Vizard.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageBlockComment.xaml
    /// </summary>
    public partial class PageBlockComment : Page
    {
        public static GameComments TheComments { get; set; } 
        public PageBlockComment(GameComments SelComment)
        {
            InitializeComponent();
            CMBStatValue.ItemsSource = App.Connection.Blocet.ToList();
            TheComments = SelComment;
            DataContext = SelComment;
        }
        private void CMBStatValue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMBStatValue.SelectedItem != null)
            {
                var SelBlocet = CMBStatValue.SelectedItem as Blocet;
                TheComments.IsBlocet = SelBlocet.Id_blocet;
                App.Connection.SaveChanges();
            }
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageShowComments());
        }

        private void CLEventBlockUser(object sender, RoutedEventArgs e)
        {
            var SelUser = TheComments.Users;
            NavigationService.Navigate(new PageBlockUser(SelUser));
        }

        private void ClEventBlockGame(object sender, RoutedEventArgs e)
        {
            var SelGame = TheComments.Games;
            NavigationService.Navigate(new PageBlockGame(SelGame));
        }
    }
}
