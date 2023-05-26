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
    /// Логика взаимодействия для PageShowUserFoBlock.xaml
    /// </summary>
    public partial class PageShowUserFoBlock : Page
    {
        public PageShowUserFoBlock()
        {
            InitializeComponent();
            UserList.ItemsSource = App.Connection.Users.Where(z=>z.Role_id != 3).ToList();
        }

        private void ClEventBlocket(object sender, SelectionChangedEventArgs e)
        {
            if (UserList.SelectedItem != null)
            {
                var SelUser = UserList.SelectedItem as Users;
                NavigationService.Navigate(new PageBlockUser(SelUser));
            };
        }
    }
}
