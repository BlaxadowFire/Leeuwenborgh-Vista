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
using System.Media;

namespace TicTacToewpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string P1 = "Soviet";
        public string P2 = "America";
        public bool win = false;
        public SoundPlayer myPlayer = new SoundPlayer();
        public int[] turns = {0,0,0,0,0,0,0,0,0};

        public MainWindow()
        {
            InitializeComponent();
            lblPlayerTurn.Content = P1;
        }

        public void UserInput(object sender, RoutedEventArgs e)
        {
            if (lblPlayerTurn.Content == P1)
            {
                ((Image)sender).Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                turns[Convertname(sender)] = 1;
                CheckWin(sender, e);
                lblPlayerTurn.Content = P2;
            }
            else
            {
                ((Image)sender).Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                turns[Convertname(sender)] = 2;
                CheckWin(sender, e);
                lblPlayerTurn.Content = P1;
            }
            if (!win)
            {
                ((Image)sender).MouseDown -= UserInput;
            }
            win = false;
        }

        public void ResetClick(object sender, RoutedEventArgs e)
        {
            A.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            A.MouseDown -= UserInput;
            A.MouseDown += UserInput;
            B.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            B.MouseDown -= UserInput;
            B.MouseDown += UserInput;
            C.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            C.MouseDown -= UserInput;
            C.MouseDown += UserInput;
            D.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            D.MouseDown -= UserInput;
            D.MouseDown += UserInput;
            E.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            E.MouseDown -= UserInput;
            E.MouseDown += UserInput;
            F.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            F.MouseDown -= UserInput;
            F.MouseDown += UserInput;
            G.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            G.MouseDown -= UserInput;
            G.MouseDown += UserInput;
            H.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            H.MouseDown -= UserInput;
            H.MouseDown += UserInput;
            I.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            I.MouseDown -= UserInput;
            I.MouseDown += UserInput;
            
            /*
            foreach (int turn in turns)
            {
                turns[turn] = 0;
            }
            */
            for (int i = 0; i < turns.Length; i++)
            {
                turns[i] = 0;
            }

            lblPlayerTurn.Content = P1;
            win = true;
        }

        public void CheckWin(object sender, RoutedEventArgs e)
        {
            if (turns[0] == turns[1] && turns[1] == turns[2] && turns[0] != 0 || turns[3] == turns[4] && turns[4] == turns[5] && turns[3] != 0 || turns[6] == turns[7] && turns[7] == turns[8] && turns[6] != 0 ||
                turns[0] == turns[3] && turns[3] == turns[6] && turns[0] != 0 || turns[1] == turns[4] && turns[4] == turns[7] && turns[1] != 0 || turns[2] == turns[5] && turns[5] == turns[8] && turns[2] != 0 ||
                turns[0] == turns[4] && turns[4] == turns[8] && turns[0] != 0 || turns[2] == turns[4] && turns[4] == turns[6] && turns[2] != 0)
            {
                if (lblPlayerTurn.Content == P1)
                {
                    myPlayer.SoundLocation = "Assets/soviet.wav";
                    myPlayer.Play();
                }
                MessageBox.Show(lblPlayerTurn.Content + " Won");
                myPlayer.Stop();
                ResetClick(sender, e);
            }
            else
            {
                if (lblPlayerTurn.Content == P1)
                {
                    lblPlayerTurn.Content = P2;
                }
                else
                {
                    lblPlayerTurn.Content = P1;
                }
            }
        }

        public int Convertname(object sender)
        {
            switch (((Image)sender).Name)
            {
                case "A":
                    {
                        return 0;
                    }
                case "B":
                    {
                        return 1;
                    }
                case "C":
                    {
                        return 2;
                    }
                case "D":
                    {
                        return 3;
                    }
                case "E":
                    {
                        return 4;
                    }
                case "F":
                    {
                        return 5;
                    }
                case "G":
                    {
                        return 6;
                    }
                case "H":
                    {
                        return 7;
                    }
                case "I":
                    {
                        return 8;
                    }
                default: 
                    {
                        return -1;
                    }
            }
        }
    }
}
