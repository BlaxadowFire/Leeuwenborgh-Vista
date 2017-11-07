using System;
using System.Threading;
using System.IO;


/* Console.Write("Dit ");
 Console.ForegroundColor = ConsoleColor.Red;
 Console.Write("is ");
 Console.ForegroundColor = ConsoleColor.Blue;
 Console.Write("een ");
 Console.ForegroundColor = ConsoleColor.Green;
 Console.Write("test.\r\n");
 Console.ForegroundColor = ConsoleColor.White;*/
namespace Subwaj
{
    class Puzzle1
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

        public static bool BlnAiTurn = true;

        public static string StrPlayer1;
        public static string StrPlayer2;
        public static string StrCurrentPlayer;
        public static bool BlnGameOVer;
        public static string StrCpChoice;
        public static string StrUserInput = string.Empty;

        public static string Restart = "y";

        public static bool Firstrun = true;

        public static void StartPuzzle1()
        {
            if (Program.BlnPuzzle1 == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = Program.StrTxtLocation + "Rooms/Room2/Room2.txt";
                string[] introText = File.ReadAllLines(strFilename);
                foreach (string strIntroText in introText)
                {
                    Program.Ss.SpeakAsync(strIntroText);
                    foreach (char cha in strIntroText)
                    {
                        Console.Write(cha);
                        if (cha == ',')
                        {
                            Thread.Sleep(Program.IntSleep400); //400
                        }
                        Thread.Sleep(40); //40
                    }
                    Console.Write("\r\n");
                    Thread.Sleep(Program.IntSleep400); //400
                }
                Thread.Sleep(1000);
                Console.Clear();
                Program.BlnPuzzle1 = true;
            }

                StrPlayer1 = Environment.UserName;
                StrPlayer2 = "THE MOST AMAZING AI EVER CREATED";
                StrCurrentPlayer = StrPlayer1;
                do
                {
                    if (StrCurrentPlayer == "THE MOST AMAZING AI EVER CREATED")
                    {
                        BlnAiTurn = true;
                        FuncBot();
                    }
                    else
                    {
                        DrawGrid();
                        StrUserInput = Console.ReadKey().Key.ToString();

                        TurnCheck();
                        Turn();
                    }
                    CheckIfWon();
                    SwitchTurn();
                } while (BlnGameOVer == false);
                lblplayagain:
                Console.Clear();
                Program.Ss.SpeakAsync("It's a tie!");
                Console.WriteLine("It's a tie!");
                Program.Ss.SpeakAsync("Do you want to play again? y/n");
                Console.WriteLine("Do you want to play again? y/n");
                Restart = Console.ReadKey().Key.ToString();
                if (Restart == "N")
                {
                    Console.Clear();
                    Program.Ss.SpeakAsync("YOU HAVE NO CHOICE");
                    Console.WriteLine("YOU HAVE NO CHOICE");
                    Thread.Sleep(1500);
                }
                else if (Restart != "Y")
                {
                    goto lblplayagain;
                }
                FuncRestart();


        }


        public static void TurnCheck()
        {
            StrCpChoice = StrCurrentPlayer == StrPlayer1 ? "X" : "O";
            /* This does the same as above
            if (StrCurrentPlayer == StrPlayer1)
            {
                StrCpChoice = "X";
            }
            else
            {
                StrCpChoice = "O";
            }
            */
        }
        public static void Turn()
        {
            Console.Clear();
            switch (StrUserInput)
            {
                case "D1":
                case "NumPad1":
                    {
                        if (A == "1")
                        {
                            A = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "D2":
                case "NumPad2":
                    {
                        if (B == "2")
                        {
                            B = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "D3":
                case "NumPad3":
                    {
                        if (C == "3")
                        {
                            C = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "D4":
                case "NumPad4":
                    {
                        if (D == "4")
                        {
                            D = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "D5":
                case "NumPad5":
                    {
                        if (E == "5")
                        {
                            E = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "D6":
                case "NumPad6":
                    {
                        if (F == "6")
                        {
                            F = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "D7":
                case "NumPad7":
                    {
                        if (G == "7")
                        {
                            G = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "D8":
                case "NumPad8":
                    {
                        if (H == "8")
                        {
                            H = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "D9":
                case "NumPad9":
                    {
                        if (I == "9")
                        {
                            I = StrCpChoice;
                        }
                        else
                        {
                            Program.Ss.SpeakAsync("Error, this one is already taken");
                            Console.WriteLine("Error, this one is already taken");
                            Thread.Sleep(1000);
                            StartPuzzle1();
                        }
                        break;
                    }
                case "E":
                    {
                        if (Program.BlnDebug)
                        {
                            A = StrCpChoice;
                            B = StrCpChoice;
                            C = StrCpChoice;
                            D = StrCpChoice;
                            E = StrCpChoice;
                            F = StrCpChoice;
                            G = StrCpChoice;
                            H = StrCpChoice;
                            I = StrCpChoice;
                            Console.Clear();
                            DrawGrid();
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                case "Escape":
                    {
                        Program.InGameMenu();
                        break;
                    }
                default:
                    {
                        Program.Ss.SpeakAsync("Error, give valid input");
                        Console.WriteLine("Error, give valid input");
                        Thread.Sleep(1500);
                        StartPuzzle1();
                        break;
                    }
            }
        }
        public static void SwitchTurn()
        {
            StrCurrentPlayer = StrCurrentPlayer == StrPlayer1 ? StrPlayer2 : StrPlayer1;
        }
        public static void CheckIfWon()
        {
            if (A == B && B == C)
            {
                Won();
            }
            else if (D == E && E == F)
            {
                Won();
            }
            else if (G == H && H == I)
            {
                Won();
            }
            else if (A == D && D == G)
            {
                Won();
            }
            else if (B == E && E == H)
            {
                Won();
            }
            else if (C == F && F == I)
            {
                Won();
            }
            else if (A == E && E == I)
            {
                Won();
            }
            else if (C == E && E == G)
            {
                Won();
            }
            if (A != "1" && B != "2" && C != "3" && D != "4" && E != "5" && F != "6" && G != "7" && H != "8" && I != "9")
            {
                BlnGameOVer = true;
            }
        }

        public static void GridColor()
        {
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
        }



        public static void DrawGrid()
        {
            Console.Clear();
            Program.Ss.SpeakAsyncCancelAll();
            Program.Ss.Speak("Last turn: " + StrUserInput);
            Console.WriteLine("Last turn:{0}", StrUserInput);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} Give input\r\n\r\n", StrCurrentPlayer);
            Console.BackgroundColor = ConsoleColor.Black;

            GridColor(); Console.Write(A); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(B); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(C); Console.ForegroundColor = ConsoleColor.White; Console.Write("\r\n");

            Console.WriteLine("----------");

            GridColor(); Console.Write(D); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(E); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(F); Console.ForegroundColor = ConsoleColor.White; Console.Write("\r\n");

            Console.WriteLine("----------");

            GridColor(); Console.Write(G); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(H); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(I); Console.ForegroundColor = ConsoleColor.White; Console.Write("\r\n");

            Console.WriteLine("----------\r\n");
        }
        public static void Won()
        {
            GridColor(); Console.Write(A); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(B); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(C); Console.ForegroundColor = ConsoleColor.White; Console.Write("\r\n");

            Console.WriteLine("----------");

            GridColor(); Console.Write(D); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(E); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(F); Console.ForegroundColor = ConsoleColor.White; Console.Write("\r\n");

            Console.WriteLine("----------");

            GridColor(); Console.Write(G); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(H); Console.ForegroundColor = ConsoleColor.White; Console.Write(" | ");
            GridColor(); Console.Write(I); Console.ForegroundColor = ConsoleColor.White; Console.Write("\r\n");
            if (StrPlayer2 == "THE MOST AMAZING AI EVER CREATED" && StrPlayer2 == StrCurrentPlayer)
            {
                Program.Ss.SpeakAsync("YOU JUST LOST FROM " + StrPlayer2);
                Console.WriteLine("YOU JUST LOST FROM {0}", StrPlayer2);
                Thread.Sleep(1500);
                FuncRestart();
            }

            Program.Ss.SpeakAsync("Congratulations " + StrCurrentPlayer + ", you Won!\r\nPress any key to continue!");
            Console.WriteLine("Congratulations {0}, you Won!\r\nPress any key to continue!", StrCurrentPlayer);
            
            Console.ReadKey();
            Program.BlnPuzzle1Complete = true;
            Program.Room2();
            
        }
        public static void FuncRestart()
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

            SwitchTurn();
            BlnGameOVer = false;
            StrCpChoice = string.Empty;
            StrUserInput = string.Empty;

            Console.Clear();

            StartPuzzle1();
        }
        public static void FuncBot()
        {

            //OFFENSIVE

            /*O|O|@
            * 4|O|O
            * O|8|O
            */
            if (C == "3" && BlnAiTurn)
            {
                if (A == "O" && B == "O" || G == "O" && E == "O" || F == "O" && I == "O")
                {
                    StrUserInput = "3";
                    C = "O";
                    BlnAiTurn = false;
                }
            }
            /* @|O|O
             * O|O|6
             * O|8|O
             */
            if (A == "1" && BlnAiTurn)
            {
                if (C == "O" && B == "O" || I == "O" && E == "O" || D == "O" && G == "O")
                {
                    StrUserInput = "1";
                    A = "O";
                    BlnAiTurn = false;
                }
            }

            /*O|@|O
            * 4|O|6
            * 7|O|9
            */
            if (B == "2" && BlnAiTurn)
            {
                if (A == "O" && C == "O" || E == "O" && H == "O")
                {
                    StrUserInput = "2";
                    B = "O";
                    BlnAiTurn = false;
                }
            }

            /*1|2|O
            * O|O|@
            * 7|8|O
            */
            if (F == "6" && BlnAiTurn)
            {
                if (D == "O" && E == "O" || C == "O" && I == "O")
                {
                    StrUserInput = "6";
                    F = "O";
                    BlnAiTurn = false;
                }
            }

            /*O|2|3
            * @|O|O
            * O|8|9
            */
            if (D == "4" && BlnAiTurn)
            {
                if (F == "O" && E == "O" || A == "O" && G == "O")
                {
                    StrUserInput = "4";
                    D = "O";
                    BlnAiTurn = false;
                }
            }

            /*O|O|O
            * O|@|O
            * O|O|O
            */
            if (E == "5" && BlnAiTurn)
            {
                if (D == "O" && F == "O" || A == "O" && I == "O" || B == "O" && H == "O" || C == "O" && G == "O")
                {
                    StrUserInput = "5";
                    E = "O";
                    BlnAiTurn = false;
                }
            }

            /*O|2|O
            * 4|O|O
            * O|O|@
            */
            if (I == "9" && BlnAiTurn)
            {
                if (G == "O" && H == "O" || C == "O" && F == "O" || A == "O" && E == "O")
                {
                    StrUserInput = "9";
                    I = "O";
                    BlnAiTurn = false;
                }
            }

            /*O|2|O
            * O|O|6
            * @|O|O
            */
            if (G == "7" && BlnAiTurn)
            {
                if (I == "O" && H == "O" || A == "O" && D == "O" || C == "O" && E == "O")
                {
                    StrUserInput = "7";
                    G = "O";
                    BlnAiTurn = false;
                }
            }

            /*1|O|3
            * 4|O|6
            * O|@|O
            */
            if (H == "8" && BlnAiTurn)
            {
                if (G == "O" && I == "O" || B == "O" && E == "O")
                {
                    StrUserInput = "8";
                    H = "O";
                    BlnAiTurn = false;
                }
            }


            //DEFENSIVE


            /*X|X|@
            * 4|X|X
            * X|8|X
            */
            if (C == "3" && BlnAiTurn)
            {
                if (A == "X" && B == "X" || G == "X" && E == "X" || F == "X" && I == "X")
                {
                    StrUserInput = "3";
                    C = "O";
                    BlnAiTurn = false;
                }
            }
            /* @|X|X
             * X|X|6
             * X|8|X
             */
            if (A == "1" && BlnAiTurn)
            {
                if (C == "X" && B == "X" || I == "X" && E == "X" || D == "X" && G == "X")
                {
                    StrUserInput = "1";
                    A = "O";
                    BlnAiTurn = false;
                }
            }

            /*X|@|X
            * 4|X|6
            * 7|X|9
            */
            if (B == "2" && BlnAiTurn)
            {
                if (A == "X" && C == "X" || E == "X" && H == "X")
                {
                    StrUserInput = "2";
                    B = "O";
                    BlnAiTurn = false;
                }
            }

            /*1|2|X
            * X|X|@
            * 7|8|X
            */
            if (F == "6" && BlnAiTurn)
            {
                if (D == "X" && E == "X" || C == "X" && I == "X")
                {
                    StrUserInput = "6";
                    F = "O";
                    BlnAiTurn = false;
                }
            }

            /*X|2|3
            * @|X|X
            * X|8|9
            */
            if (D == "4" && BlnAiTurn)
            {
                if (F == "X" && E == "X" || A == "X" && G == "X")
                {
                    StrUserInput = "4";
                    D = "O";
                    BlnAiTurn = false;
                }
            }

            /*X|X|X
            * X|@|X
            * X|X|X
            */
            if (E == "5" && BlnAiTurn)
            {
                if (D == "X" && F == "X" || A == "X" && I == "X" || B == "X" && H == "X" || C == "X" && G == "X")
                {
                    StrUserInput = "5";
                    E = "O";
                    BlnAiTurn = false;
                }
            }

            /*X|2|X
            * 4|X|X
            * X|X|@
            */
            if (I == "9" && BlnAiTurn)
            {
                if (G == "X" && H == "X" || C == "X" && F == "X" || A == "X" && E == "X")
                {
                    StrUserInput = "9";
                    I = "O";
                    BlnAiTurn = false;
                }
            }

            /*X|2|X
            * X|X|6
            * @|X|X
            */
            if (G == "7" && BlnAiTurn)
            {
                if (I == "X" && H == "X" || A == "X" && D == "X" || C == "X" && E == "X")
                {
                    StrUserInput = "7";
                    G = "O";
                    BlnAiTurn = false;
                }
            }

            /*1|X|3
            * 4|X|6
            * X|@|X
            */
            if (H == "8" && BlnAiTurn)
            {
                if (G == "X" && I == "X" || B == "X" && E == "X")
                {
                    StrUserInput = "8";
                    H = "O";
                    BlnAiTurn = false;
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
            if (E == "5" && BlnAiTurn)
            {
                StrUserInput = "5";
                E = "O";
                BlnAiTurn = false;
            }

            /*1|2|3
            * 4|5|6
            * 7|8|@
            */
            if (I == "9" && BlnAiTurn)
            {
                StrUserInput = "9";
                I = "O";
                BlnAiTurn = false;
            }

            /*1|2|3
            * 4|5|6
            * @|8|9
            */
            if (G == "7" && BlnAiTurn)
            {
                StrUserInput = "7";
                G = "O";
                BlnAiTurn = false;
            }

            /*@|2|3
            * 4|5|6
            * 7|8|9
            */
            if (A == "1" && BlnAiTurn)
            {
                StrUserInput = "1";
                A = "O";
                BlnAiTurn = false;
            }

            /*1|2|@
            * 4|5|6
            * 7|8|9
            */
            if (C == "3" && BlnAiTurn)
            {
                StrUserInput = "3";
                C = "O";
                BlnAiTurn = false;
            }

            /*1|@|3
            * 4|5|6
            * 7|8|9
            */
            if (B == "2" && BlnAiTurn)
            {
                StrUserInput = "2";
                B = "O";
                BlnAiTurn = false;
            }

            /*1|2|3
            * 4|5|@
            * 7|8|9
            */
            if (F == "6" && BlnAiTurn)
            {
                StrUserInput = "6";
                F = "O";
                BlnAiTurn = false;
            }

            /*1|2|3
            * 4|5|6
            * 7|@|9
            */
            if (H == "8" && BlnAiTurn)
            {
                StrUserInput = "8";
                H = "O";
                BlnAiTurn = false;
            }

            /*1|2|3
            * @|5|6
            * 7|8|9
            */
            if (D == "4" && BlnAiTurn)
            {
                StrUserInput = "4";
                D = "O";
                BlnAiTurn = false;
            }
        }
    }
}
// Add a temporary file where it will automatically add every move, it will reset when the game is started (in StartPuzzle1 before first do) or restarted.