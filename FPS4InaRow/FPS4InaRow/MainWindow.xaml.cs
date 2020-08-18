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

namespace FPS4InaRow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[,] ArrFieldGrid = new int[7, 6];

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SwitchColor(object sender, RoutedEventArgs e)
        {
            //Converterthingy(sender);
            Sandbox(sender);
        }

        public void Sandbox(object sender)
        {
            Name = ((Button)sender).Name;
                int y = Name[1];
                int x = Name[3];
            string stry = y.ToString();
            string strx = x.ToString();
            MessageBox.Show(strx + ", " + stry);
        }

        public string Backroundbuttons(int x, int y)
        {
            return "R" + y + "C" + x;

        }
        public void Converterthingy(object sender)
        {
            switch(((Button)sender).Name)
            {
                case "R0C0":
                    {
                        for(int i = 5; i >= 0; i--)
                        {
                            if (ArrFieldGrid[0, i] == 0)
                            {
                                ArrFieldGrid[0, i] = 1;
                                Backroundbuttons(0,i);
                            }
                        }
                        break;
                    }
                case "R0C1":
                    {

                        if (ArrFieldGrid[0, 1] == 0)
                        {
                            for (int i = 5; i >= 0; i--)
                            {
                                ArrFieldGrid[0, i] = 1;

                            }
                        }
                        break;
                    }
                case "R0C2":
                    {

                        if (ArrFieldGrid[0, 2] == 0)
                        {
                            for (int i = 5; i >= 0; i--)
                            {
                                ArrFieldGrid[0, i] = 1;

                            }
                        }
                        break;
                    }
                case "R0C3":
                    {

                        if (ArrFieldGrid[0, 3] == 0)
                        {
                            for (int i = 5; i >= 0; i--)
                            {
                                ArrFieldGrid[0, i] = 1;

                            }
                        }
                        break;
                    }
                case "R0C4":
                    {

                        if (ArrFieldGrid[0, 4] == 0)
                        {
                            for (int i = 5; i >= 0; i--)
                            {
                                ArrFieldGrid[0, i] = 1;

                            }
                        }
                        break;
                    }
                case "R0C5":
                    {

                        if (ArrFieldGrid[0, 5] == 0)
                        {
                            for (int i = 5; i >= 0; i--)
                            {
                                ArrFieldGrid[0, i] = 1;

                            }
                        }
                        break;
                    }
                case "R0C6":
                    {

                        if (ArrFieldGrid[0, 6] == 0)
                        {
                            for (int i = 5; i >= 0; i--)
                            {
                                ArrFieldGrid[0, i] = 1;

                            }
                        }
                        break;
                    }
            }
        }
    }
}
