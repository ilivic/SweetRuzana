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
    /// Логика взаимодействия для PageBlockUser.xaml
    /// </summary>
    public partial class PageBlockUser : Page
    {
        public static Users TheUser { get; set; }
        public PageBlockUser(Users SelUser)
        {
            InitializeComponent();
            CMBStatValue.ItemsSource = App.Connection.Blocet.ToList();
            DataContext = SelUser;    
            TheUser= SelUser;
        }

        private void CMBStatValue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMBStatValue.SelectedItem != null)
            {
                var SelBlocet = CMBStatValue.SelectedItem as Blocet;
                TheUser.IsBlocet = SelBlocet.Id_blocet;
                App.Connection.SaveChanges();
                NavigationService.Navigate(new PageShowUserFoBlock()); 
            }
        }
    }
}
