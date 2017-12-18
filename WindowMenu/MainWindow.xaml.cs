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

namespace WindowMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            _NavigationFrame.Navigate(new Pages.Home());
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //txtEditor.Text = "";
        }

        private void OnExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AboutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //txtEditor.Text = "";
        }

        private void GoToHomePage(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new Pages.Home());
        }

        private void GoToAboutPage(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new Pages.About());
        }
    }


}
