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
using Rsteam.ClassApp;

namespace Rsteam.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageAuthrization.xaml
    /// </summary>
    public partial class PageAuthrization : Page
    {
        public PageAuthrization()
        {
            InitializeComponent();
        }

        private void ClEventAuthorization(object sender, RoutedEventArgs e)
        {
            try
            {
                var DataUser = App.Connection.Users.Where(z => z.Login == TxtLogin.Text && z.Password == TxtPassword.Password).FirstOrDefault();
                if (DataUser != null)
                {
                    if (DataUser.Role_id == 2 && DataUser.IsBlocet == 2)
                    {
                        ClassCorrUser.CorrUser = DataUser;
                        NavigationService.Navigate(new PageMenuMain());
                    }
                    else
                    {
                        MessageBox.Show($"Fo rele {DataUser.Roles.Titlel} connection Block", "Infomation", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("User is not Real", "Infomation", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClEventRegistration(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageRegistration());
        }
    }
}
