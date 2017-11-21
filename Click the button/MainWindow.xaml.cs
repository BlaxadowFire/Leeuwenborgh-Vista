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
using System.Threading;

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
            double dblRandomLocationH = randomlocation.Next(0, Convert.ToInt32(Main.Height));
            double dblRandomLocationW = randomlocation.Next(0, Convert.ToInt32(Main.Width));
            image.Margin = new Thickness(dblRandomLocationW, dblRandomLocationH, 0, 0);
            if (image.Margin.Left >= (Main.Width - 50) || image.Margin.Top >= (Main.Height - 50) || image.Margin.Left <= 10 || image.Margin.Top <= 10)
            {
                image.Margin = new Thickness(40, 68, 0, 0);
            }
            this.Background = Brushes.White;
            Ss.SpeakAsyncCancelAll();
            Ss.SpeakAsync("HAHA, can't catch me");
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ss.SpeakAsyncCancelAll();
            Ss.SpeakAsync(File.ReadAllText("items/TextFile1.txt"));
        }

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ss.SpeakAsyncCancelAll();
            this.Background = Brushes.Red;
            Ss.Speak("You got me!");
        }
    }
}
