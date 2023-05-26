using Microsoft.Win32;
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
using System.IO;
using Vizard.ClassApp;

namespace Vizard.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageEditAkk.xaml
    /// </summary>
    public partial class PageEditAkk : Page
    {
        public static byte[] image { get; set; }
        public PageEditAkk()
        {
            InitializeComponent();
            DataContext = ClassCorrUser.CorrUser;
        }

        private void ClEventSave(object sender, RoutedEventArgs e)
        {
            var ChecLogin = App.Connection.Users.Where(z => z.Login == TxtLogin.Text && z.id_user != ClassCorrUser.CorrUser.id_user).FirstOrDefault();
            if (ChecLogin == null)
            {
                App.Connection.SaveChanges();
            }
            else
            {
                MessageBox.Show("Error Login hav ib base");
            }
        }

        private void CLEventAddPhoto(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() != null)
                {
                    image = File.ReadAllBytes(dialog.FileName);
                    ImageProfil.Source = new BitmapImage(new Uri(dialog.FileName, UriKind.RelativeOrAbsolute));
                    ClassCorrUser.CorrUser.Photo = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
