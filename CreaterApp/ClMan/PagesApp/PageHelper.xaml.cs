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
using ClMan.ADOApp;
using ClMan.ClassApp;

namespace ClMan.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageHelper.xaml
    /// </summary>
    public partial class PageHelper : Page
    {
        public PageHelper()
        {
            InitializeComponent();
            ListAnswer.ItemsSource = App.Connection.Appeal.Where(z => z.User_id == ClassCorrUser.CorrUser.id_user).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Appeal NewAppeal = new Appeal()
                {
                    Text = TxtAppeal.Text,
                    User_id = ClassCorrUser.CorrUser.Role_id,
                    DateAppeal = DateTime.Now,
                    IsVisibli = true,
                    isClose = 1
                };
                App.Connection.Appeal.Add(NewAppeal);
                App.Connection.SaveChanges();
                MessageBox.Show("Запрос в службу поддержки отправлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
