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
    /// Логика взаимодействия для PageAddFrends.xaml
    /// </summary>
    public partial class PageAddFrends : Page
    {
        public PageAddFrends()
        {
            InitializeComponent();
            Refresh();
                }
        public void Refresh()
        {
            ListFrends.ItemsSource = App.Connection.FrendSection.Where(z => z.User_id_Revers == ClassCorrUser.CorrUser.id_user || z.User_id == ClassCorrUser.CorrUser.id_user).ToList();

        }

        private void BuClEventAddFton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var UserOne = App.Connection.Users.Where(z => z.XName == TxtXName.Text).FirstOrDefault();
                if (UserOne != null)
                {
                    FrendSection NewFrend = new FrendSection()
                    {
                        User_id_Revers = UserOne.id_user,
                        User_id = ClassCorrUser.CorrUser.id_user
                    };
                    App.Connection.FrendSection.Add(NewFrend);
                    App.Connection.SaveChanges();
                    MessageBox.Show("вы успешно джобавили друга (или друг друга)");
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ListFrends.SelectedItem != null)
            {
                var SelFrend = ListFrends.SelectedItem as FrendSection;
                NavigationService.Navigate(new PageMessages(SelFrend));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListFrends.SelectedItem != null)
            {
                var SelFrend = ListFrends.SelectedItem as FrendSection;
                App.Connection.FrendSection.Remove(SelFrend);
                App.Connection.SaveChanges();
                MessageBox.Show("вы успешно удалили друга (или друг друга)");
            }
        }
    }
}
