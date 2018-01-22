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

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Tafel_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt16(((Button)sender).Content);
            MainWindow.MainFrame.Navigate(new MenuKaart());
        }

        private void ShowMenuKaart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new MenuKaart());
        }

        private void ShowBonnen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Bonnen());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Agenda()); 
        }
    }
}
