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
using Microsoft.Win32;
using Rsteam.ADOApp;
using System.IO;
using Rsteam.ClassApp;

namespace Rsteam.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageEditGame.xaml
    /// </summary>
    public partial class PageEditGame : Page
    {
        public static Games Game { get; set; }
        public PageEditGame(Games SelGame)
        {
            InitializeComponent();
            DataContext = SelGame;
            Game = SelGame;
        }

        private void ClEventditPhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != null)
            {
                Game.Photo = File.ReadAllBytes(dialog.FileName);
                DataContext = Game;
                ImaGeGame.Source = new BitmapImage(new Uri(dialog.FileName, UriKind.RelativeOrAbsolute));
            }
        }

        private void ClEventSaveChang(object sender, RoutedEventArgs e)
        {
            App.Connection.SaveChanges();
            MessageBox.Show("Edit Is Ok", "Infomation", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new PageShowGameFoEdit());
        }
    }
}
