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
using System.Speech.Synthesis;
using System.IO;

namespace Click_the_button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static SpeechSynthesizer Ss = new SpeechSynthesizer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void imagejump(object sender, MouseEventArgs e)
        {
            Random randomlocation = new Random();
            double dblRandomLocationH = randomlocation.Next(0, Convert.ToInt32(Height));
            double dblRandomLocationW = randomlocation.Next(0, Convert.ToInt32(Width));
            image.Margin = new Thickness(dblRandomLocationW, dblRandomLocationH, 0, 0);
            if (image.Margin.Left >= (this.Width - 50) || image.Margin.Top >= (this.Height - 50) || image.Margin.Left <= 10 || image.Margin.Top <= 10)
            {
                image.Margin = new Thickness(40, 68, 0, 0);
            }
            Ss.SpeakAsyncCancelAll();
            Ss.SpeakAsync("HAHA, can't catch me");
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ss.SpeakAsyncCancelAll();
            Ss.SpeakAsync(File.ReadAllText("items/TextFile1.txt"));
        }
    }
}
