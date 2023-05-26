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
using ClMan.ADOApp;
using ClMan.ClassApp;

namespace ClMan.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageShowAllGame.xaml
    /// </summary>
    public partial class PageShowAllGame : Page
    {
        public static List<Games> gameList { get; set; }
        public PageShowAllGame()
        {
            InitializeComponent();
            Defolt();
        }
        public void Defolt()
        {
            CMBProdaction.SelectedIndex = -1;
            CMBReiting.SelectedIndex = -1;
            CMBProdaction.ItemsSource = App.Connection.Prodactions.ToList();
            CMBReiting.ItemsSource = App.Connection.Reiteg.ToList();
            gameList = ClassGetData.GameListDonHaw();
            ListGames.ItemsSource = gameList;
        }
        public void Refresh()
        {
            ListGames.ItemsSource = gameList;
        }
        private void TxtSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            gameList = gameList.Where(z => z.Title.Contains(TxtSerch.Text)).ToList();
            Refresh();
        }

        private void CMBProdaction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMBProdaction.SelectedItem != null)
            {
                if (ListGames.Items.Count != 0)
                {
                    var SelProdaction = CMBProdaction.SelectedItem as Prodactions;
                    gameList = gameList.Where(z => z.prodaction_id == SelProdaction.id_prodaction).ToList();
                    Refresh();
                }
                else
                {
                    Defolt();
                }
            }
        }

        private void CMBReiting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            if(CMBReiting.SelectedItem != null)
            { 
            if (ListGames.Items.Count != 0)
            {
                var SelReiting = CMBReiting.SelectedItem as Reiteg;
                gameList = gameList.Where(z => z.Reiting_id == SelReiting.id_reiting).ToList();
                Refresh();
            }
            else
            {
                Defolt();
            }
            }
        }

        private void ListGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListGames.SelectedItem != null)
            {
                var Selgame = ListGames.SelectedItem as Games;
                NavigationService.Navigate(new PageSaleGame(Selgame));
            }
        }

        private void ClEventPriceUp(object sender, RoutedEventArgs e)
        {
            gameList = gameList.OrderBy(z=>z.Price).ToList();
                 Refresh();
        }

        private void ClEventPriceDown(object sender, RoutedEventArgs e)
        {
            gameList = gameList.OrderBy(z => z.Title).ToList();
            Refresh();
        }

        private void ClEventTitleUp(object sender, RoutedEventArgs e)
        {
            gameList = gameList.OrderByDescending(z => z.Title).ToList();
            Refresh();
        }

        private void ClEventTitleDown(object sender, RoutedEventArgs e)
        {
            gameList = gameList.OrderByDescending(z => z.Price).ToList();
            Refresh();
        }

        private void ClEventSortDate(object sender, RoutedEventArgs e)
        {
            Defolt();
        }

        private void ClEvenMuF(object sender, RoutedEventArgs e)
        {
            var SelFeiv = App.Connection.Feivarit.Where(z => z.User_id == ClassCorrUser.CorrUser.id_user).ToList();
            gameList.Clear();
            List<Games> TimeList = new List<Games>();
            foreach (var feiv in SelFeiv.ToList())
            {
                TimeList.Add(feiv.Games);
            }
            Refresh();
            ListGames.ItemsSource = TimeList.ToList();
        }
    }
}
