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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tafel_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt16(((Button)sender).Content);
            MenuKaart menuKaart = new MenuKaart();
            menuKaart.Show();
            this.Close();
        }

        private void ShowMenuKaart_Click(object sender, RoutedEventArgs e)
        {
            MenuKaart menuKaart = new MenuKaart();
            menuKaart.Show();
            this.Close();
            
        }

        private void ShowBonnen_Click_1(object sender, RoutedEventArgs e)
        {
            Bonnen bonnen = new Bonnen();
            bonnen.Show();
            this.Close();
        }
    }
}
