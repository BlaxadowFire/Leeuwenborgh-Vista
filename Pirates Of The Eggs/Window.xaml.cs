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
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static Frame MainFrame = new Frame();

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            MainGrid.Children.Add(MainFrame);
            MainFrame.VerticalAlignment = VerticalAlignment.Stretch;
            MainFrame.HorizontalAlignment = HorizontalAlignment.Stretch;
            MainFrame.Navigate(new Main());
        }
    }
}
