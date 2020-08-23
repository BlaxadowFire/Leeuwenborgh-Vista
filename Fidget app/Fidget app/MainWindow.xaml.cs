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

namespace Fidget_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int PB1Temp = 0;
        public static int PB2Temp = 0;
        public static int PB3Temp = 0;
        public static int PB4Temp = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            PB1.Value = random.Next(0, 100);
            PB2.Value = random.Next(0, 100);
            PB3.Value = random.Next(0, 100);
            PB4.Value = random.Next(0, 100);
            PB1Temp = Convert.ToInt16(PB1.Value);
            PB2Temp = Convert.ToInt16(PB2.Value);
            PB3Temp = Convert.ToInt16(PB3.Value);
            PB4Temp = Convert.ToInt16(PB4.Value);
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PB1.Value = PB1Temp + Slider1.Value;
        }

        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PB2.Value = PB2Temp + Slider2.Value;
        }

        private void Slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PB3.Value = PB3Temp + Slider3.Value;
        }

        private void Slider4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PB4.Value = PB4Temp + Slider4.Value;
        }
    }
}
