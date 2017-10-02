using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2._0
{
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

        public static bool blnAiTurn = true;

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
                    Console.WriteLine("There is an AI function in this game\r\nIf you want to use the ai, give Player 2 the name:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("'ai' 'bot' '0'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Have Fun\r\n");
                    labelp1:
                    Console.WriteLine("Player1 (X), enter your name:");
                    strPlayer1 = Console.ReadLine();
                    if (strPlayer1 == "")
                    {
                        strPlayer1 = "p1";
                    }
                    else if (strPlayer1 == "ai" || strPlayer1 == "bot" || strPlayer1 == "AI" || strPlayer1 == "BOT" || strPlayer1 == "0")
                    {
                        Console.WriteLine("Player1 can't be a bot.");
                        goto labelp1;
                    }
                    Console.WriteLine("\r\n\r\nPlayer2 (O), enter your name:");
                    strPlayer2 = Console.ReadLine();
                    if (strPlayer2 == "")
                    {
                        strPlayer2 = "p2";
                    }
                    if (strPlayer2 == "ai" || strPlayer2 == "bot" || strPlayer2 == "AI" || strPlayer2 == "BOT" || strPlayer2 == "0")
                    {
                        strPlayer2 = "THE MOST AMAZING AI EVER CREATED";
                    }
                    strCurrentPlayer = strPlayer1;
                    firstrun = false;
                }
                do
                {
                    if (strCurrentPlayer == "THE MOST AMAZING AI EVER CREATED")
                    {
                        blnAiTurn = true;
                        Program.funcbot();
                    }
                    else
                    {
                        Program.drawgrid();
                        strUserInput = Console.ReadLine();
                    
                        Program.TurnCheck();
                        Program.Turn();
                    }
                    Program.checkifwon();
                    Program.SwitchTurn();
                }
                while (blnGameOVer == false);
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Do you want to play again? y/n");
                restart = Console.ReadLine();
                if (restart == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Program.funcrestart();
                }
            }
            while (true);


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
            switch (strUserInput)
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
            Console.WriteLine("Last turn:{0}", strUserInput);
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
            if (strPlayer2 == "THE MOST AMAZING AI EVER CREATED" && strPlayer2 == strCurrentPlayer)
            {
                Console.WriteLine("{0} | {1} | {2} ", A, B, C);
                Console.WriteLine("----------");
                Console.WriteLine("{0} | {1} | {2} ", D, E, F);
                Console.WriteLine("----------");
                Console.WriteLine("{0} | {1} | {2} ", G, H, I);
                Console.WriteLine("----------\r\n");
                Console.WriteLine("YOU JUST LOST FROM {0}", strPlayer2);
            }
            else
            {
                Console.WriteLine("{0} | {1} | {2} ", A, B, C);
                Console.WriteLine("----------");
                Console.WriteLine("{0} | {1} | {2} ", D, E, F);
                Console.WriteLine("----------");
                Console.WriteLine("{0} | {1} | {2} ", G, H, I);
                Console.WriteLine("----------\r\n");
                Console.WriteLine("Congratulations {0}, you won!", strCurrentPlayer);
            }
            Console.WriteLine("Do you want to play again? y/n");
            restart = Console.ReadLine();
           
            if (restart == "n" || restart =="N")
            {
                Environment.Exit(0);
            }
            else
            {
                Program.funcrestart();
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

            Console.WriteLine("Do you play with the same players?");
            string strCheckPlayer = Console.ReadLine();
            if (strCheckPlayer == "n" || strCheckPlayer == "N")
            {
                strPlayer1 = string.Empty;
                strPlayer2 = string.Empty;
                firstrun = true;
            }
            Program.SwitchTurn();
            blnGameOVer = false;
            strCPChoice = string.Empty;
            strUserInput = string.Empty;

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

            //OFFENSIVE

            /*O|O|@
            * 4|O|O
            * O|8|O
            */
            if (C == "3" && blnAiTurn == true)
            {
                if (A == "O" && B == "O" || G == "O" && E == "O" || F == "O" && I == "O")
                {
                    strUserInput = "3";
                    C = "O";
                    blnAiTurn = false;
                }
            }
            /* @|O|O
             * O|O|6
             * O|8|O
             */
            if (A == "1" && blnAiTurn == true)
            {
                if (C == "O" && B == "O" || I == "O" && E == "O" || D == "O" && G == "O")
                {
                    strUserInput = "1";
                    A = "O";
                    blnAiTurn = false;
                }
            }

            /*O|@|O
            * 4|O|6
            * 7|O|9
            */
            if (B == "2" && blnAiTurn == true)
            {
                if (A == "O" && C == "O" || E == "O" && H == "O")
                {
                    strUserInput = "2";
                    B = "O";
                    blnAiTurn = false;
                }
            }

            /*1|2|O
            * O|O|@
            * 7|8|O
            */
            if (F == "6" && blnAiTurn == true)
            {
                if (D == "O" && E == "O" || C == "O" && I == "O")
                {
                    strUserInput = "6";
                    F = "O";
                    blnAiTurn = false;
                }
            }

            /*O|2|3
            * @|O|O
            * O|8|9
            */
            if (D == "4" && blnAiTurn == true)
            {
                if (F == "O" && E == "O" || A == "O" && G == "O")
                {
                    strUserInput = "4";
                    D = "O";
                    blnAiTurn = false;
                }
            }

            /*O|O|O
            * O|@|O
            * O|O|O
            */
            if (E == "5" && blnAiTurn == true)
            {
                if (D == "O" && F == "O" || A == "O" && I == "O" || B == "O" && H == "O" || C == "O" && G == "O")
                {
                    strUserInput = "5";
                    E = "O";
                    blnAiTurn = false;
                }
            }

            /*O|2|O
            * 4|O|O
            * O|O|@
            */
            if (I == "9" && blnAiTurn == true)
            {
                if (G == "O" && H == "O" || C == "O" && F == "O" || A == "O" && E == "O")
                {
                    strUserInput = "9";
                    I = "O";
                    blnAiTurn = false;
                }
            }

            /*O|2|O
            * O|O|6
            * @|O|O
            */
            if (G == "7" && blnAiTurn == true)
            {
                if (I == "O" && H == "O" || A == "O" && D == "O" || C == "O" && E == "O")
                {
                    strUserInput = "7";
                    G = "O";
                    blnAiTurn = false;
                }
            }

            /*1|O|3
            * 4|O|6
            * O|@|O
            */
            if (H == "8" && blnAiTurn == true)
            {
                if (G == "" && I == "X" || B == "O" && E == "O")
                {
                    strUserInput = "8";
                    H = "O";
                    blnAiTurn = false;
                }
            }


            //DEFENSIVE


            /*X|X|@
            * 4|X|X
            * X|8|X
            */
            if (C == "3" && blnAiTurn == true)
            {
                if (A == "X" && B == "X" || G == "X" && E == "X" || F == "X" && I == "X")
                {
                    strUserInput = "3";
                    C = "O";
                    blnAiTurn = false;
                }
            }
            /* @|X|X
             * X|X|6
             * X|8|X
             */
            if (A == "1" && blnAiTurn == true)
            {
                if (C == "X" && B == "X" || I == "X" && E == "X" || D == "X" && G == "X")
                {
                    strUserInput = "1";
                    A = "O";
                    blnAiTurn = false;
                }
            }

            /*X|@|X
            * 4|X|6
            * 7|X|9
            */
            if (B == "2" && blnAiTurn == true)
            {
                if (A == "X" && C == "X" || E == "X" && H == "X")
                {
                    strUserInput = "2";
                    B = "O";
                    blnAiTurn = false;
                }
            }

            /*1|2|X
            * X|X|@
            * 7|8|X
            */
            if (F == "6" && blnAiTurn == true)
            {
                if (D == "X" && E == "X" || C == "X" && I == "X")
                {
                    strUserInput = "6";
                    F = "O";
                    blnAiTurn = false;
                }
            }

            /*X|2|3
            * @|X|X
            * X|8|9
            */
            if (D == "4" && blnAiTurn == true)
            {
                if (F == "X" && E == "X" || A == "X" && G == "X")
                {
                    strUserInput = "4";
                    D = "O";
                    blnAiTurn = false;
                }
            }

            /*X|X|X
            * X|@|X
            * X|X|X
            */
            if (E == "5" && blnAiTurn == true)
            {
                if (D == "X" && F == "X" || A == "X" && I == "X" || B == "X" && H == "X" || C == "X" && G == "X")
                {
                    strUserInput = "5";
                    E = "O";
                    blnAiTurn = false;
                }
            }

            /*X|2|X
            * 4|X|X
            * X|X|@
            */
            if (I == "9" && blnAiTurn == true)
            {
                if (G == "X" && H == "X" || C == "X" && F == "X" || A == "X" && E == "X")
                {
                    strUserInput = "9";
                    I = "O";
                    blnAiTurn = false;
                }
            }

            /*X|2|X
            * X|X|6
            * @|X|X
            */
            if (G == "7" && blnAiTurn == true)
            {
                if (I == "X" && H == "X" || A == "X" && D == "X" || C == "X" && E == "X")
                {
                    strUserInput = "7";
                    G = "O";
                    blnAiTurn = false;
                }
            }

            /*1|X|3
            * 4|X|6
            * X|@|X
            */
            if (H == "8" && blnAiTurn == true)
            {
                if (G == "X" && I == "X" || B == "X" && E == "X")
                {
                    strUserInput = "8";
                    H = "O";
                    blnAiTurn = false;
                }
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

            //PASSIVE


            /*1|2|3
            * 4|@|6
            * 7|8|9
            */
            if (E == "5" && blnAiTurn == true)
            {
                strUserInput = "5";
                E = "O";
                blnAiTurn = false;
            }

            /*1|2|3
            * 4|5|6
            * 7|8|@
            */
            if (I == "9" && blnAiTurn == true)
            {
                strUserInput = "9";
                I = "O";
                blnAiTurn = false;
            }

            /*1|2|3
            * 4|5|6
            * @|8|9
            */
            if (G == "7" && blnAiTurn == true)
            {
                strUserInput = "7";
                G = "O";
                blnAiTurn = false;
            }

            /*@|2|3
            * 4|5|6
            * 7|8|9
            */
            if (A == "1" && blnAiTurn == true)
            {
                strUserInput = "1";
                A = "O";
                blnAiTurn = false;
            }

            /*1|2|@
            * 4|5|6
            * 7|8|9
            */
            if (C == "3" && blnAiTurn == true)
            {
                strUserInput = "3";
                C = "O";
                blnAiTurn = false;
            }

            /*1|@|3
            * 4|5|6
            * 7|8|9
            */
            if (B == "2" && blnAiTurn == true)
            {
                strUserInput = "2";
                B = "O";
                blnAiTurn = false;
            }

            /*1|2|3
            * 4|5|@
            * 7|8|9
            */
            if (F == "6" && blnAiTurn == true)
            {
                strUserInput = "6";
                F = "O";
                blnAiTurn = false;
            }

            /*1|2|3
            * 4|5|6
            * 7|@|9
            */
            if (H == "8" && blnAiTurn == true)
            {
                strUserInput = "8";
                H = "O";
                blnAiTurn = false;
            }

            /*1|2|3
            * @|5|6
            * 7|8|9
            */
            if (D == "4" && blnAiTurn == true)
            {
                strUserInput = "4";
                D = "O";
                blnAiTurn = false;
            }

        }
    }
}
// Add a temporary file where it will automatically add every move, it will reset when the game is started (in main before first do) or restarted.