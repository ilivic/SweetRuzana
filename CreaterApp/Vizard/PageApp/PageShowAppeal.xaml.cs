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
    /// Логика взаимодействия для PageShowAppeal.xaml
    /// </summary>
    public partial class PageShowAppeal : Page
    {
        public static List<Appeal> appeals { get; set; }
        public PageShowAppeal()
        {
            InitializeComponent();
            CMBStat.ItemsSource = App.Connection.AppealCloseType.ToList();
            Defolt();
        }
        public void Defolt()
        {
            appeals = new List<Appeal>(App.Connection.Appeal.Where(z=>z.IsVisibli == true).ToList());
            ListAppeal.ItemsSource = appeals;
        }
        public void Refresh()
        {
            ListAppeal.ItemsSource = appeals;
        }

        private void ListAppeal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListAppeal.SelectedItem != null)
            {
                var SelAppeal = ListAppeal.SelectedItem as Appeal;
                NavigationService.Navigate(new PageUltimateAnswer(SelAppeal));
            }
        }

        private void CMBStat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMBStat.SelectedItem != null)
            {
                if (ListAppeal.Items.Count == 0)
                {
                    Defolt();
                }
                else
                {
                    var SelClos = CMBStat.SelectedItem as AppealCloseType;
                    appeals = appeals.Where(z => z.isClose == SelClos.id_ACT).ToList();
                    Refresh();
                }
            }
            else
            {
                Defolt();   
            }
        }
    }
}
