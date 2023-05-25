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
using Rsteam.ADOApp;
using Rsteam.ClassApp;

namespace Rsteam.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageDellGame.xaml
    /// </summary>
    public partial class PageDellGame : Page
    {
        public static List<Games> GameListDate { get; set; }
        public static Creaters Creaters { get; set; }

        public PageDellGame()
        {
            InitializeComponent();
            var Createss = ClassCorrUser.CorrUser.Creaters.First();
            ListGames.ItemsSource = App.Connection.Games.Where(z => z.prodaction_id == Createss.Prodaction_id).ToList();
            CMBSortR.ItemsSource = App.Connection.Reiteg.ToList();
            CMBSortS.ItemsSource = App.Connection.Blocet.ToList();
            Defolt();
        }
        public void Defolt()
        {
            var UserCreater = ClassCorrUser.CorrUser.Creaters.First();
            Creaters = UserCreater;
            GameListDate = new List<Games>(App.Connection.Games.Where(z => z.prodaction_id == UserCreater.Prodaction_id && z.IsBlocet != 2).ToList());
            CMBSortR.SelectedIndex = -1;
            CMBSortS.SelectedIndex = -1;
            TxtSerc.Text = "";
            Refresh();
        }
        public void Refresh()
        {
            ListGames.ItemsSource = GameListDate.ToList();

        }

        private void ClEventSorUp(object sender, RoutedEventArgs e)
        {
            GameListDate = GameListDate.OrderBy(z => z.Price).ToList();
            Refresh();
        }

        private void ClEventSortDown(object sender, RoutedEventArgs e)
        {
            GameListDate = GameListDate.OrderByDescending(z => z.Price).ToList();
            Refresh();
        }

        private void InputEventSerch(object sender, TextChangedEventArgs e)
        {
            if (TxtSerc.Text.Length == 0)
            {
                Defolt();
            }
            else
            {
                GameListDate = GameListDate.Where(z => z.Title.Contains(TxtSerc.Text)).ToList();
                Refresh();
            }

        }

        private void ClEventDefoltList(object sender, RoutedEventArgs e)
        {
            Defolt();

        }

        private void SelEvntFiltrReitng(object sender, SelectionChangedEventArgs e)
        {
            if (CMBSortR.SelectedItem != null)
            {
                if (GameListDate.ToList().Count == 0)
                {
                    Defolt();
                }
                else
                {
                    var SelReitung = (CMBSortR.SelectedItem as Reiteg);
                    GameListDate = GameListDate.Where(z => z.Reiting_id == SelReitung.id_reiting).ToList();
                    Refresh();
                }
            }
        }

        private void SelEventFilterStatus(object sender, SelectionChangedEventArgs e)
        {
            if (CMBSortS.SelectedItem != null)
            {
                if (GameListDate.ToList().Count == 0)
                {
                    Defolt();
                }
                else
                {
                    var SelBlocket = (CMBSortS.SelectedItem as Blocet);
                    GameListDate = GameListDate.Where(z => z.IsBlocet == SelBlocket.Id_blocet).ToList();
                    Refresh();
                }
            }
        }

        private void ListGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListGames.SelectedItem != null)
            {
                var SelGame = ListGames.SelectedItem as Games;
                if (MessageBox.Show("Question dell This game&", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    App.Connection.Games.Remove(SelGame);
                    App.Connection.SaveChanges();
                    MessageBox.Show("Dell Is OK","Infomation",MessageBoxButton.OK,MessageBoxImage.Information);
                }
            }
        }

    }
}
