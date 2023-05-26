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
    /// Логика взаимодействия для PageSaleGame.xaml
    /// </summary>
    public partial class PageSaleGame : Page
    {
        public static Games TheGame {get ;set;}
        public PageSaleGame(Games SelGame)
        {
            InitializeComponent();
            DataContext = SelGame;
            TheGame = SelGame;
        }

        private void ClEventByGame(object sender, RoutedEventArgs e)
        {
            try
            {

                if (TheGame.Price <= ClassCorrUser.CorrBalance.Value)
                {
                    var lib = ClassCorrUser.CorrUser.Librarys.First();
                    LibrarysGames librarys = new LibrarysGames()
                    {
                        Game_id = TheGame.id_game,
                        Library_id = lib.id_library,
                        LastStartDate = DateTime.Now
                    };
                    App.Connection.LibrarysGames.Add(librarys);
                    ClassCorrUser.CorrBalance.Value -= TheGame.Price;
                    var DellFeit = App.Connection.Feivarit.Where(z => z.User_id == ClassCorrUser.CorrUser.id_user && z.Game_id == TheGame.id_game).First();
                    App.Connection.Feivarit.Remove(DellFeit);
                    App.Connection.SaveChanges();
                    MessageBox.Show("покупка успешно совершена");

                }
                else
                {
                    MessageBox.Show("вы бичара (хачик) ебанный");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClEventFeivoritGame(object sender, RoutedEventArgs e)
        {
            try
            {
                var Datefeiv = App.Connection.Feivarit.Where(z => z.Game_id == TheGame.id_game && z.User_id == ClassCorrUser.CorrUser.id_user).FirstOrDefault();
                if (Datefeiv == null)
                {
                    Feivarit NewFeiv = new Feivarit()
                    {
                        Game_id = TheGame.id_game,
                        User_id = ClassCorrUser.CorrUser.id_user
                    };
                    App.Connection.Feivarit.Add(NewFeiv);
                    App.Connection.SaveChanges();
                    MessageBox.Show("Игра доюавлена в список желаемого");
                }
                else
                {
                    MessageBox.Show("Игра уже в вашем списке желаемого");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClLinkGame(object sender, RoutedEventArgs e)
        {

        }
    }
}
