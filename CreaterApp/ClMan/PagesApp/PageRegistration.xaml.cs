using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace ClMan.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public static byte[] image { get; set; }
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ClEventRegistration(object sender, RoutedEventArgs e)
        {
            try
            {
                if (App.Connection.Users.Where(z => z.Login == TxtLoign.Text).FirstOrDefault() == null)
                {
                    Users NewUser = new Users()
                    {
                        FullName = TxtName.Text,
                        XName = TxtNuckName.Text,
                        Login = TxtLoign.Text,
                        Password = TxtPassword.Text,
                        Photo = image,
                        Role_id = 1,
                        IsBlocet = 2
                    };
                    App.Connection.Users.Add(NewUser);
                    Librarys NewLib = new Librarys()
                    {
                        DataCreate = DateTime.Now,
                        Users = NewUser
                    };
                    App.Connection.Librarys.Add(NewLib);
                    Balances NewBalances = new Balances()
                    {
                        Users = NewUser,
                        Value = 0
                    };
                    App.Connection.Balances.Add(NewBalances);
                    App.Connection.SaveChanges();
                    MessageBox.Show("Add is Ok");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClEventSElectPhoto(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() != null)
                {
                    image = File.ReadAllBytes(dialog.FileName);
                }
                (sender as Button).Background = Brushes.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
