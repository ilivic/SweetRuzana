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
using ClMan.ClassApp;
using ClMan.ADOApp;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace ClMan.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageEditAkk.xaml
    /// </summary>
    public partial class PageEditAkk : Page
    {
        public PageEditAkk()
        {
            InitializeComponent();
            DataContext = ClassCorrUser.CorrUser;
            TxtBall.Text = ClassCorrUser.CorrBalance.Value.ToString();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != null)
            {
                ClassCorrUser.CorrUser.Photo = File.ReadAllBytes(dialog.FileName);
                (sender as Image).Source = new BitmapImage(new Uri(dialog.FileName, UriKind.RelativeOrAbsolute));
                MessageBox.Show("Add Photo is ok");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClassCorrUser.CorrBalance.Value += int.Parse(TxtEBall.Text);
                Process.Start("https://qiwi.com/");
                App.Connection.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClEventSaveEdits(object sender, RoutedEventArgs e)
        {

            if (App.Connection.Users.Where(z => z.Login == TxtLogin.Text
            && z.id_user != ClassCorrUser.CorrUser.id_user).FirstOrDefault() == null)
            {
                App.Connection.SaveChanges();
                MessageBox.Show("Edit is ok");
            }
            else
            {
                MessageBox.Show("Такой логин уже есть в базе");
            }
        }
    }
}
