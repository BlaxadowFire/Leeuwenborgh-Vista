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
    /// Interaction logic for Opsplitsen.xaml
    /// </summary>
    public partial class Opsplitsen : Page
    {
        public Opsplitsen()
        {
            InitializeComponent();
        }

        private void ShowMenuKaart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }

        private void Btn_ClickNumber(object sender, RoutedEventArgs e)
        {
            TxtBlockNumber.Text = TxtBlockNumber.Text + ((Button)sender).Content;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TxtBlck1.Text = Convert.ToString(Convert.ToInt32(TxtBox1.Text) / Convert.ToInt32(TxtBlockNumber.Text));

        }
    }
}
