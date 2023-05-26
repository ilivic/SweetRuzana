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
    /// Логика взаимодействия для PageShowComments.xaml
    /// </summary>
    public partial class PageShowComments : Page
    {
        public static List<GameComments> CommentsList { get; set; }
        public PageShowComments()
        {
            InitializeComponent();
            Defolt();
        }

        public void Defolt()
        {
            CommentsList = App.Connection.GameComments.Where(z=>z.IsBlocet == 2).ToList();
            ListCommets.ItemsSource = CommentsList.ToList();
        }
        public void Refresh()
        {
            ListCommets.ItemsSource = CommentsList.ToList();
        }

        private void TxtSerchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ListCommets.Items.Count != 0)
            {
                CommentsList = CommentsList.Where(z => z.Text.Contains(TxtSerchText.Text)).ToList();
                Refresh();
            }
            else
            {
                Defolt();
            }
        }

        private void TxtSercXNameTextChanged(object sender, TextChangedEventArgs e)
        {
            if (ListCommets.Items.Count != 0)
            {
                CommentsList = CommentsList.Where(z => z.Users.XName.Contains(TxtSercXName.Text)).ToList();
                Refresh();
            }
            else
            {
                Defolt();
            }
        }

        private void ClEventShowAll(object sender, RoutedEventArgs e)
        {
                Defolt();
        }

        private void TxtSercGameTextChanged(object sender, TextChangedEventArgs e)
        {
            if (ListCommets.Items.Count != 0)
            {
                CommentsList = CommentsList.Where(z => z.Games.Title.Contains(TxtSercGame.Text)).ToList();
                Refresh();
            }
            else
            {
                Defolt();
            }
        }

        private void ListCommetsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListCommets.SelectedItem != null)
            {
                var SelComment = ListCommets.SelectedItem as GameComments;
                NavigationService.Navigate(new PageBlockComment(SelComment));
            }
        }
    }
}
