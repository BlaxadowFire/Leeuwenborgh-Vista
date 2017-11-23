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
        public int PlayerAi = 0;
        public bool AiEnabled;
        public bool AiMadeMove;
        public SoundPlayer MyPlayer = new SoundPlayer();
        public int[] Turns = {0,0,0,0,0,0,0,0,0};

        public MainWindow()
        {
            InitializeComponent();
            ListBox.Items.Add("Wins");
            ListBox.Items.Add("____________________\r\n");
            LblPlayerTurn.Content = P1;
        }

        public void UserInput(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Visibility = Visibility.Hidden;
            if ((string)LblPlayerTurn.Content == P1 && PlayerAi != 1)
            {
                int i = ConvertImage(sender);
                if (i != -1 && Turns[i] == 0)
                {
                    ConvertButton(sender);
                    Turns[i] = 1;
                    CheckWin(sender, e);
                    LblPlayerTurn.Content = P2;
                    CheckAi(sender);
                }
            }
            else if ((string)LblPlayerTurn.Content == P2 && PlayerAi != 2)
            {
                int i = ConvertImage(sender);
                if (i != -1 && Turns[i] == 0)
                {
                    ConvertButton(sender);
                    Turns[i] = 2;
                    CheckWin(sender, e);
                    LblPlayerTurn.Content = P1;
                    CheckAi(sender);
                }
            }
            else if ((string)LblPlayerTurn.Content == P1 && PlayerAi == 1)
            {
                int i = ConvertImage(sender);
                if (i != -1 && Turns[i] == 0)
                {
                    ConvertButton(sender);
                    Turns[i] = 1;
                    CheckWin(sender, e);
                    LblPlayerTurn.Content = P1;
                }
            }
            else if ((string)LblPlayerTurn.Content == P2 && PlayerAi == 2)
            {
                int i = ConvertImage(sender);
                if (i != -1 && Turns[i] == 0)
                {
                    ConvertButton(sender);
                    Turns[i] = 2;
                    CheckWin(sender, e);
                    LblPlayerTurn.Content = P2;
                }
            }
        }

        public void CheckAi(object sender)
        {
            if (AiEnabled)
            {
                //checks if it can match win or lose condition
                
                if (!AiMadeMove)
                {
                    //make use of switchcase to see what last move was.
                    CheckLastMove(sender);
                }


                LblPlayerTurn.Content = (string)LblPlayerTurn.Content == P1 ? P2 : P1;
                AiMadeMove = false;
            }
        }

        public void HelpMenu(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click on the place you want your turn to be.");
            MessageBox.Show("The goal is to get your flag 3 times in a row.");
            MessageBox.Show("Press Reset in case of tie.");
        }

        public void ResetClick(object sender, RoutedEventArgs e)
        {
            ImgA.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            ImgB.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            ImgC.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            ImgD.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            ImgE.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            ImgF.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            ImgG.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            ImgH.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            ImgI.Source = new BitmapImage(new Uri("Assets/empty.png", UriKind.Relative));
            
            /*
            foreach (int turn in turns)
            {
                turns[turn] = 0;
            }
            */
            for (int i = 0; i < Turns.Length; i++)
            {
                Turns[i] = 0;
            }
            {
                BtnA.Visibility = Visibility.Visible;
                BtnB.Visibility = Visibility.Visible;
                BtnC.Visibility = Visibility.Visible;
                BtnD.Visibility = Visibility.Visible;
                BtnE.Visibility = Visibility.Visible;
                BtnF.Visibility = Visibility.Visible;
                BtnG.Visibility = Visibility.Visible;
                BtnH.Visibility = Visibility.Visible;
                BtnI.Visibility = Visibility.Visible;
            }
        }

        public void CheckWin(object sender, RoutedEventArgs e)
        {
            if (Turns[0] == Turns[1] && Turns[1] == Turns[2] && Turns[0] != 0 || Turns[3] == Turns[4] && Turns[4] == Turns[5] && Turns[3] != 0 || Turns[6] == Turns[7] && Turns[7] == Turns[8] && Turns[6] != 0 ||
                Turns[0] == Turns[3] && Turns[3] == Turns[6] && Turns[0] != 0 || Turns[1] == Turns[4] && Turns[4] == Turns[7] && Turns[1] != 0 || Turns[2] == Turns[5] && Turns[5] == Turns[8] && Turns[2] != 0 ||
                Turns[0] == Turns[4] && Turns[4] == Turns[8] && Turns[0] != 0 || Turns[2] == Turns[4] && Turns[4] == Turns[6] && Turns[2] != 0)
            {
                ListBox.Items.Add(LblPlayerTurn.Content);
                if ((string)LblPlayerTurn.Content == P1)
                {
                    MyPlayer.SoundLocation = "Assets/soviet.wav";
                    MyPlayer.Play();
                }
                MessageBox.Show(LblPlayerTurn.Content + " Won");
                MyPlayer.Stop();
                ResetClick(sender, e);
            }
            else
            {
                LblPlayerTurn.Content = (string)LblPlayerTurn.Content == P1 ? P2 : P1;
            }
        }

        public int ConvertImage(object sender)
        {
            switch (((Button)sender).Name)
            {
                case "BtnA":
                    {
                        return 0;
                    }
                case "BtnB":
                    {
                        return 1;
                    }
                case "BtnC":
                    {
                        return 2;
                    }
                case "BtnD":
                    {
                        return 3;
                    }
                case "BtnE":
                    {
                        return 4;
                    }
                case "BtnF":
                    {
                        return 5;
                    }
                case "BtnG":
                    {
                        return 6;
                    }
                case "BtnH":
                    {
                        return 7;
                    }
                case "BtnI":
                    {
                        return 8;
                    }
                default: 
                    {
                        return -1;
                    }
            }
        }
        public void ConvertButton(object sender)
        {
            if ((string)LblPlayerTurn.Content == P1)
            {
                switch (((Button) sender).Name)
                {
                    case "BtnA":
                    {
                        ImgA.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                    case "BtnB":
                    {
                        ImgB.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                    case "BtnC":
                    {
                        ImgC.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                    case "BtnD":
                    {
                        ImgD.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                    case "BtnE":
                    {
                        ImgE.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                    case "BtnF":
                    {
                        ImgF.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                    case "BtnG":
                    {
                        ImgG.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                    case "BtnH":
                    {
                        ImgH.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                    case "BtnI":
                    {
                        ImgI.Source = new BitmapImage(new Uri("Assets/p1.png", UriKind.Relative));
                        break;
                    }
                }
            }
            else
            {
                switch (((Button)sender).Name)
                {
                    case "BtnA":
                    {
                        ImgA.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                    case "BtnB":
                    {
                        ImgB.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                    case "BtnC":
                    {
                        ImgC.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                    case "BtnD":
                    {
                        ImgD.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                    case "BtnE":
                    {
                        ImgE.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                    case "BtnF":
                    {
                        ImgF.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                    case "BtnG":
                    {
                        ImgG.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                    case "BtnH":
                    {
                        ImgH.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                    case "BtnI":
                    {
                        ImgI.Source = new BitmapImage(new Uri("Assets/p2.png", UriKind.Relative));
                        break;
                    }
                }
            }
        }

        public void CheckLastMove(object sender)
        {
            switch (ConvertImage(sender))
            {
                case 0:
                case 4:
                {
                    UserInput(BtnI, null);
                    break;
                }
                case 2:
                {
                    UserInput(BtnG, null);
                    break;
                }
                case 1:
                case 3:
                case 5:
                case 7:
                {
                    UserInput(BtnE, null);
                    break;
                }
                case 6:
                {
                    UserInput(BtnC, null);
                    break;
                }

                case 8:
                {
                    UserInput(BtnA, null);
                    break;
                }
            }
            AiMadeMove = true;
        }
        public void SwitchAi(object sender, RoutedEventArgs e)
        {
            AiEnabled = !AiEnabled;
            if (AiEnabled)
            {
                PlayerAi = (string)LblPlayerTurn.Content == P1 ? 2 : 1;
            }
            else
            {
                PlayerAi = 0;
            }
            BtnSwitchAi.Background = AiEnabled ? Brushes.Green : Brushes.Red;
        }

        public void AiAttack()
        {
            if (Turns[0] == Turns[1])
            {
                UserInput(BtnI, null);
            }
        }
        public void AiDefend()
        {

        }
    }
}
