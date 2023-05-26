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

namespace Vizard.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void ClEventOpenPage(object sender, RoutedEventArgs e)
        {
            switch (CMBSelection.Text)
            {
                case "Users":
                    {
                        MainNaviFrame.NavigationService.Navigate(new PageShowUserFoBlock());
                        break;
                    }
                case "Games":
                    {
                        MainNaviFrame.NavigationService.Navigate(new PageShowGameFoBLock());
                        break;
                    }
                case "Coments":
                    {
                        MainNaviFrame.NavigationService.Navigate(new PageShowComments());
                        break;
                    }
                case "Profil":
                    {
                        MainNaviFrame.NavigationService.Navigate(new PageEditAkk());
                        break;
                    }
                case "Appeals":
                    {
                        MainNaviFrame.NavigationService.Navigate(new PageShowAppeal());
                        break;
                    }
            }
        }
        
    }
}
