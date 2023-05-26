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
using System.IO;
using Rsteam.ClassApp;
using Microsoft.Win32;

namespace Rsteam.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageAddGame.xaml
    /// </summary>
    public partial class PageAddGame : Page
    {
        public static byte[] image { get; set; }
        public PageAddGame()
        {
            InitializeComponent();
            CMBREating.ItemsSource = App.Connection.Reiteg.ToList();
        }

        private void ClEventAddGame(object sender, RoutedEventArgs e)
        {
            try
            {
                var reitinSel = (CMBREating.SelectedItem as Reiteg);
                Games NewGames = new Games()
                {
                    Title = TxtName.Text,
                    Photo = image,
                    prodaction_id = ClassCorrUser.CorrUser.Creaters.First().Prodaction_id,
                    DataCreate = DateTime.Now,
                    Price = (int.Parse(TxtPrice.Text)),
                    IsBlocet = 1,
                    Diskription = TxtDis.Text,
                    Reiting_id = reitinSel.id_reiting,
                    PathFoGame = TxtPath.Text
                };
                App.Connection.Games.Add(NewGames);
                App.Connection.SaveChanges();
                MessageBox.Show("add Game is OK","Infomation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClEventAddPhoto(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() != null)
                {
                    image = File.ReadAllBytes(dialog.FileName);
                    (sender as Button).Background = Brushes.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
