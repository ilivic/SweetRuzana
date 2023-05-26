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
using System.Windows.Threading;

namespace ClMan.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageMessages.xaml
    /// </summary>
    public partial class PageMessages : Page
    {
        public static FrendSection TheFs { get; set; }
        DispatcherTimer Time = new DispatcherTimer();
        public PageMessages(FrendSection Fs)
        {
            InitializeComponent();
            TheFs = Fs;
            Time.Tick += Time_Tick;
            Time.Interval = new TimeSpan(3);
            Time.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            ListMessage.ItemsSource = App.Connection.Chats.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Chats newMessage = new Chats()
                {
                    Text = TxtMessage.Text,
                    FS_id = TheFs.id_FS,
                    User_id = ClassCorrUser.CorrUser.id_user,
                    DateTime = DateTime.Now
                };
                App.Connection.Chats.Add(newMessage);
                App.Connection.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
