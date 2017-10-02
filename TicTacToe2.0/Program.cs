using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2._0
{//user moet naam ingeven
    class Program
    {
        public static string A = "1";
        public static string B = "2";
        public static string C = "3";
        public static string D = "4";
        public static string E = "5";
        public static string F = "6";
        public static string G = "7";
        public static string H = "8";
        public static string I = "9";

        public static string strPlayer1;
        public static string strPlayer2;
        public static string strCurrentPlayer;
        public static bool blnGameOVer = false;
        public static string strCPChoice;
        public static string strUserInput = string.Empty;

        public static string restart = "y";

        public static bool firstrun = true;

        static void Main()
        {
            do
            {
                if (firstrun == true)
                {
                    Console.Title = "TicTacToe By Nando";
                    Console.WriteLine("Currently developing ai for this game, please do not use bot or ai as name. \r\nHave Fun\r\n");
                    Console.WriteLine("Player1 (X), enter your name:");
                    strPlayer1 = Console.ReadLine();
                    Console.WriteLine("\r\n\r\nPlayer2 (O), enter your name:");
                    strPlayer2 = Console.ReadLine();
                    strCurrentPlayer = strPlayer1;
                    firstrun = false;
                }
                do
                {
                    Program.drawgrid();
                    if (strCurrentPlayer == "bot" || strCurrentPlayer == "ai")
                    {

                    }
                    else
                    {
                        Program.strUserInput = Console.ReadLine();
                    }
                    Program.TurnCheck();
                    Program.Turn();
                    Program.checkifwon();
                    Program.SwitchTurn();
                }
                while (blnGameOVer == false);
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Do you want to play again? y/n");
                restart = Console.ReadLine();
                if (restart == "y")
                {
                    Program.funcrestart();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            while (restart == "y");
            Environment.Exit(0);

            
        }
        public static void TurnCheck()
        {
            if (strCurrentPlayer == strPlayer1)
            {
                strCPChoice = "X";
            }
            else
            {
                strCPChoice = "O";
            }
        }
        public static void Turn()
        {
            Console.Clear();
            switch(strUserInput)
            {
                case "1":
                    {
                        if (A == "1")
                        {
                            A = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "2":
                    {
                        if (B == "2")
                        {
                            B = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "3":
                    {
                        if (C == "3")
                        {
                            C = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "4":
                    {
                        if (D == "4")
                        {
                            D = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "5":
                    {
                        if (E == "5")
                        {
                            E = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "6":
                    {
                        if (F == "6")
                        {
                            F = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "7":
                    {
                        if (G == "7")
                        {
                            G = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "8":
                    {
                        if (H == "8")
                        {
                            H = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "9":
                    {
                        if (I == "9")
                        {
                            I = strCPChoice;
                        }
                        else
                        {
                            Console.WriteLine("Error, this one is already taken");
                            Console.ReadLine();
                            Program.Main();
                        }
                        break;
                    }
                case "bomboozle":
                    A = strCPChoice;
                    B = strCPChoice;
                    C = strCPChoice;
                    D = strCPChoice;
                    E = strCPChoice;
                    F = strCPChoice;
                    G = strCPChoice;
                    H = strCPChoice;
                    I = strCPChoice;
                    Console.Clear();
                    Program.drawgrid();
                    Console.ReadLine();

                    break;
                default:
                    {
                        Console.WriteLine("Error, give valid input");
                        Console.ReadLine();
                        Program.Main();
                        break;
                    }
            }
        }
        public static void SwitchTurn()
        {
            if (strCurrentPlayer == strPlayer1)
            {
                strCurrentPlayer = strPlayer2;
            }
            else
            {
                strCurrentPlayer = strPlayer1;
            }
        }
        public static void checkifwon()
        {
            if (A == B && B == C)
            {
                Program.won();
            }
            else if (D == E && E == F)
            {
                Program.won();
            }
            else if (G == H && H == I)
            {
                Program.won();
            }
            else if (A == D && D == G)
            {
                Program.won();
            }
            else if (B == E && E == H)
            {
                Program.won();
            }
            else if (C == F && F == I)
            {
                Program.won();
            }
            else if (A == E && E == I)
            {
                Program.won();
            }
            else if (C == E && E == G)
            {
                Program.won();
            }
            if (A != "1" && B != "2" && C != "3" && D != "4" && E != "5" && F != "6" && G != "7" && H != "8" && I != "9")
            {
                blnGameOVer = true;
            }
        }
        public static void drawgrid()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} Give input\r\n\r\n", strCurrentPlayer);
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("{0} | {1} | {2} ", A, B, C);
            Console.WriteLine("----------");
            Console.WriteLine("{0} | {1} | {2} ", D, E, F);
            Console.WriteLine("----------");
            Console.WriteLine("{0} | {1} | {2} ", G, H, I);
            Console.WriteLine("----------\r\n");
        }
        public static void won()
        {
            Console.WriteLine("Congratulations {0}, you won!", strCurrentPlayer);
            Console.WriteLine("Do you want to play again? y/n");
            restart = Console.ReadLine();
            if (restart == "y")
            {
                Program.funcrestart();
            }
            else
            {
            Environment.Exit(0);
            }
        }
        public static void funcrestart()
        {
            A = "1";
            B = "2";
            C = "3";
            D = "4";
            E = "5";
            F = "6";
            G = "7";
            H = "8";
            I = "9";

            strPlayer1 = string.Empty;
            strPlayer2 = string.Empty;
            strCurrentPlayer = string.Empty;
            blnGameOVer = false;
            strCPChoice = string.Empty;
            strUserInput = string.Empty;
            firstrun = true;
            Console.Clear();

            if (restart == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Program.Main();
            }
        }
        public static void funcbot()
        {
            //DEFENSIVE


            /*X|X|@
            * 4|5|6
            * 7|8|9
            */
            if ( A == "X" && B == "X")
            {
                C = "O";
            }

           /* @|X|X
            * 4|5|6
            * 7|8|9
            */
            if (C == "X" && B == "X")
            {
                A = "O";
            }

            /*X|@|X
            * 4|5|6
            * 7|8|9
            */
            if (A == "X" && C == "X")
            {
                B = "O";
            }

            /*1|2|3
            * X|X|@
            * 7|8|9
            */
            if (D == "X" && E == "X")
            {
                F = "O";
            }

            /*1|2|3
            * @|X|X
            * 7|8|9
            */
            if (F == "X" && E == "X")
            {
                D = "O";
            }

            /*1|2|3
            * X|@|X
            * 7|8|9
            */
            if (D == "X" && F == "X")
            {
                E = "O";
            }

            /*1|2|3
            * 4|5|6
            * X|X|@
            */
            if (G == "X" && H == "X")
            {
                I = "O";
            }

            /*1|2|3
            * 4|5|6
            * @|X|X
            */
            if (I == "X" && H == "X")
            {
                G = "O";
            }

            /*1|2|3
            * 4|5|6
            * X|@|X
            */
            if (G == "X" && I == "X")
            {
                H = "O";
            }
            /*
            /*1|2|3
            * 4|5|6
            * 7|8|9
            -/ horizontaal & verticaal & diagonaal hierin zetten
            if (X == "X" && X == "X")
            {
                X = "O";
            }
            */
            
        }
    }
}
