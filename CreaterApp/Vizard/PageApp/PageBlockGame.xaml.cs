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
    /// Логика взаимодействия для PageBlockGame.xaml
    /// </summary>
    public partial class PageBlockGame : Page
    {
        public static Games TheGame { get; set; }
        public PageBlockGame(Games SelGame)
        {
            InitializeComponent();
            CMBStatValue.ItemsSource = App.Connection.Blocet.ToList();
            TheGame = SelGame;
            DataContext= TheGame;
        }
        private void CMBStatValue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMBStatValue.SelectedItem != null)
            {
                var SelBlocet = CMBStatValue.SelectedItem as Blocet;
                TheGame.IsBlocet = SelBlocet.Id_blocet;
                App.Connection.SaveChanges();
                NavigationService.Navigate(new PageShowGameFoBLock());
            }
        }
    }
}
