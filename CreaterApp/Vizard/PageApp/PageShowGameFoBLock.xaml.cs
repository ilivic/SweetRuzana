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
    /// Логика взаимодействия для PageShowGameFoBLock.xaml
    /// </summary>
    public partial class PageShowGameFoBLock : Page
    {
        public static List<Games> GameList { get; set; }
        public PageShowGameFoBLock()
        {
            InitializeComponent();
            GameList= new List<Games>();
            CMBProdactions.ItemsSource = App.Connection.Prodactions.ToList();
            Defolt();
        }
        public void Defolt()
        {
            GameList = App.Connection.Games.ToList();
            ListGame.ItemsSource = GameList;
            TxtSerch.Text = "";
            CMBProdactions.SelectedIndex= -1;
        }
        public void Refresh()
        {
            ListGame.ItemsSource = GameList.ToList();
        }

        private void TxtSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtSerch.Text != "")
            {
                GameList = GameList.Where(z => z.Title.Contains(TxtSerch.Text)).ToList();
                Refresh();
            }
            else
            {
                Defolt();
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListGame.SelectedItem != null)
            {
                var SelGame = ListGame.SelectedItem as Games;
                NavigationService.Navigate(new PageBlockGame(SelGame));
            }
        }

        private void CMBProdactions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMBProdactions.SelectedItem == null || ListGame.Items.Count == 0)
            {
                Defolt();
            }
            else
            {
                var SelProdaction = CMBProdactions.SelectedItem as Prodactions;
                GameList = GameList.Where(z=>z.prodaction_id == SelProdaction.id_prodaction).ToList();
                Refresh();
            }
        }
    }
}
