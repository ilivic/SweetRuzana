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
using Vizard.ClassApp;
using Vizard.ADOApp;

namespace Vizard.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageAuthorization.xaml
    /// </summary>
    public partial class PageAuthorization : Page
    {
        public PageAuthorization()
        {
            InitializeComponent();
        }

        private void ClEventAutho(object sender, RoutedEventArgs e)
        {
            try
            {
                var DataUser = App.Connection.Users.Where(z => z.Login == TxtLogin.Text && z.Password == TxtPassword.Password && z.Role_id == 3).FirstOrDefault();
                if (DataUser != null)
                {
                    ClassCorrUser.CorrUser = DataUser;
                    NavigationService.Navigate(new PageMenu());
                }
                else
                {
                    MessageBox.Show("You Is Churka");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
