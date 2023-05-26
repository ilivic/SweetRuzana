using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для PageMyibrary.xaml
    /// </summary>
    public partial class PageMyibrary : Page
    {
        public PageMyibrary()
        {
            InitializeComponent();
            var TimeDat = App.Connection.Librarys.Where(z => z.User_id == ClassCorrUser.CorrUser.id_user).First();
            ListGames.ItemsSource = TimeDat.LibrarysGames.ToList();
        }

        private void ClEventStartApp(object sender, RoutedEventArgs e)
        {
            if (ListGames.SelectedItem != null)
            {
                var SelGame = ListGames.SelectedItem as Games;
                Process.Start($@"{SelGame.PathFoGame}"); 
            }
        }
    }
}
