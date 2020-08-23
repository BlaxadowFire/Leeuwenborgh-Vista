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

namespace OpendagWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            var Age = DateTime.Today.Date.Year - DateSelector.SelectedDate.Value.Date.Year;
            if (DateSelector.SelectedDate.Value.Month > DateTime.Today.Month || DateSelector.SelectedDate.Value.Month == DateTime.Today.Month && DateSelector.SelectedDate.Value.Day > DateTime.Today.Day)
            {
                Age = Age - 1;
            }
            ResultLabel.Content = Age.ToString();
            */
            ResultLabel.Content = TxtBox.Text;
        }
    }
}
