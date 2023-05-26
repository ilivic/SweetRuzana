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
using Vizard.ClassApp;

namespace Vizard.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageUltimateAnswer.xaml
    /// </summary>
    public partial class PageUltimateAnswer : Page
    {
        public static Appeal TheAppeal { get; set; }
        public PageUltimateAnswer(Appeal SelAppeal)
        {
            InitializeComponent();
            CMBStatClose.ItemsSource = App.Connection.AppealCloseType.ToList();
            TheAppeal= SelAppeal;
            DataContext = TheAppeal;
        }

        private void ClEventCreateAnswer(object sender, RoutedEventArgs e)
        {
            try
            {
                AnswerAppeal NewAnswer = new AnswerAppeal()
                {
                    Text = TxtAnswer.Text,
                    User_id = ClassCorrUser.CorrUser.id_user,
                    Appeal_id = TheAppeal.id_Appeal,
                    DateAnswer = DateTime.Now
                };
                App.Connection.AnswerAppeal.Add(NewAnswer);
                App.Connection.SaveChanges();
                MessageBox.Show("Answer add");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageShowAppeal());
        }

        private void CMBStatClose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMBStatClose.SelectedItem != null)
            {
                var SelClose = CMBStatClose.SelectedItem as AppealCloseType;
                TheAppeal.isClose = SelClose.id_ACT;
                App.Connection.SaveChanges();
                MessageBox.Show("Status edit");
            }
        }
    }
}
