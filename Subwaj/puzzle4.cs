using System;
using System.Threading;
using System.IO;

//Room6

namespace Subwaj
{   
    internal class Puzzle4
    {
        public static string[] Lever = File.ReadAllLines("files/Puzzles/Puzzle4/lever.txt");
        public static bool Lever1;
        public static bool Lever2;
        public static bool Lever3;
        public static bool Lever4;
        public static bool Lever5;
        public static bool Lever6;
        public static bool Lever7;
        public static bool Lever8;
        public static bool Lever9;

        public static int IntLever1;
        public static int IntLever2;
        public static int IntLever3;
        public static int IntLever4;
        public static int IntLever5;
        public static int IntLever6;
        public static int IntLever7;
        public static int IntLever8;
        public static int IntLever9;

        public static int IntAnswer = new Random().Next(50,511);

        public static int IntLeverAnswer;

        public static void StartPuzzle4()
        {
            
            if (Program.BlnPuzzle4 == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = Program.StrTxtLocation + "Rooms/Room6/Room6.txt";
                string[] introText = File.ReadAllLines(strFilename);
                foreach (string strIntroText in introText)
                {
                    Program.Ss.SpeakAsync(strIntroText);
                    foreach (char cha in strIntroText)
                    {
                        Console.Write(cha);
                        if (cha == ',' || cha == ':' || cha == '.' || cha == '!' || cha == '?')
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
                Program.BlnPuzzle4 = true;
            }
            
            {
                do
                {
                    Console.Clear();
                    Draw();
                    Console.CursorLeft = 0;
                    Program.DrawBottom();
                    var cki = CheckInput();
                    CheckLever(cki);
                    Levercalculator();
                } while (IntLeverAnswer != IntAnswer);
            }
            Console.Clear();
            Draw();
            Console.WriteLine("\r\n\r\n\r\n\t\t\t\tYou completed the puzzle!");
            Thread.Sleep(2000);
            Program.BlnPuzzle4Complete = true;
        }
        public static void Levercalculator()
        {
            IntLever1 = Lever1 ? 256 : 0;
            IntLever2 = Lever2 ? 128 : 0;
            IntLever3 = Lever3 ? 64 : 0;
            IntLever4 = Lever4 ? 32 : 0;
            IntLever5 = Lever5 ? 16 : 0;
            IntLever6 = Lever6 ? 8 : 0;
            IntLever7 = Lever7 ? 4 : 0;
            IntLever8 = Lever8 ? 2 : 0;
            IntLever9 = Lever9 ? 1 : 0;
        IntLeverAnswer = IntLever1 + IntLever2 + IntLever3 + IntLever4 + IntLever5 + IntLever6 + IntLever7 + IntLever8 + IntLever9;
            
        }

        public static void DrawNumberBorder(string i)
        {
            try
            {
                if (Console.CursorLeft <= 4 && Program.TimerThread.ThreadState != ThreadState.Running)
                {
                    Console.CursorLeft = 4;
                }

                Light(i);
                if (Console.CursorLeft <= 4 && Program.TimerThread.ThreadState != ThreadState.Running)
                {
                    Console.CursorLeft = 4;
                }
                Console.CursorLeft--;
                Console.Write("╔═╗");
                if (Console.CursorLeft <= 4 && Program.TimerThread.ThreadState != ThreadState.Running)
                {
                    Console.CursorLeft = 4;
                }
                Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop + 1);
                Console.Write("║{0}║", i);
                if (Console.CursorLeft <= 4 && Program.TimerThread.ThreadState != ThreadState.Running)
                {
                    Console.CursorLeft = 4;
                }
                Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop + 1);
                Console.Write("╚═╝");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {
                DrawNumberBorder(i);
            }
        }
        public static void DrawNumbers()
        {
            Console.SetCursorPosition(12, 7);
            DrawNumberBorder("1");
            Console.SetCursorPosition(22, 7);
            DrawNumberBorder("2");
            Console.SetCursorPosition(32, 7);
            DrawNumberBorder("3");
            Console.SetCursorPosition(42, 7);
            DrawNumberBorder("4");
            Console.SetCursorPosition(52, 7);
            DrawNumberBorder("5");
            Console.SetCursorPosition(62, 7);
            DrawNumberBorder("6");
            Console.SetCursorPosition(72, 7);
            DrawNumberBorder("7");
            Console.SetCursorPosition(82, 7);
            DrawNumberBorder("8");
            Console.SetCursorPosition(92, 7);
            DrawNumberBorder("9");
        }

        public static void Light(string i)
        {
            switch (i)
            {
                case "1":
                {
                    CheckLight(Lever1);
                    break;
                }
                case "2":
                {
                    CheckLight(Lever2);
                        break;
                }
                case "3":
                {
                    CheckLight(Lever3);
                        break;
                }
                case "4":
                {
                    CheckLight(Lever4);
                        break;
                }
                case "5":
                {
                    CheckLight(Lever5);
                        break;
                }
                case "6":
                {
                    CheckLight(Lever6);
                        break;
                }
                case "7":
                {
                    CheckLight(Lever7);
                        break;
                }
                case "8":
                {
                    CheckLight(Lever8);
                        break;
                }
                case "9":
                {
                    CheckLight(Lever9);
                        break;
                }
            }
        }

        public static void CheckLight(bool i)
        {
            if (i == false)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        public static void DrawBytes()
        {
            Console.SetCursorPosition(12, 19);
            Console.Write("256");
            Console.SetCursorPosition(21, 19);
            Console.Write("128");
            Console.SetCursorPosition(32, 19);
            Console.Write("64");
            Console.SetCursorPosition(42, 19);
            Console.Write("32");
            Console.SetCursorPosition(52, 19);
            Console.Write("16");
            Console.SetCursorPosition(62, 19);
            Console.Write("8");
            Console.SetCursorPosition(72, 19);
            Console.Write("4");
            Console.SetCursorPosition(82, 19);
            Console.Write("2");
            Console.SetCursorPosition(92, 19);
            Console.Write("1");
        }

        public static void Draw()
        {
            Console.WriteLine(IntAnswer);
            DrawNumbers();
            Console.SetCursorPosition(10, 10);
            CheckLeverOnOff(Lever1);
            Console.SetCursorPosition(20, 10);
            CheckLeverOnOff(Lever2);
            Console.SetCursorPosition(30, 10);
            CheckLeverOnOff(Lever3);
            Console.SetCursorPosition(40, 10);
            CheckLeverOnOff(Lever4);
            Console.SetCursorPosition(50, 10);
            CheckLeverOnOff(Lever5);
            Console.SetCursorPosition(60, 10);
            CheckLeverOnOff(Lever6);
            Console.SetCursorPosition(70, 10);
            CheckLeverOnOff(Lever7);
            Console.SetCursorPosition(80, 10);
            CheckLeverOnOff(Lever8);
            Console.SetCursorPosition(90, 10);
            CheckLeverOnOff(Lever9);
            DrawBytes();
        }

        public static string CheckInput()
        {
            return Console.ReadKey().Key.ToString();
        }

        public static void LeverOn()
        {
            for (int i = 0; i <= 7; i++)
            {
                var curLeft = Console.CursorLeft;
                Console.Write(Lever[i]);
                Console.CursorTop = Console.CursorTop + 1;
                Console.CursorLeft = curLeft;
            }
        }

        public static void LeverOff()
        {
            for (int i = 8; i <= 16; i++)
            {
                var curLeft = Console.CursorLeft;
                Console.Write(Lever[i]);
                Console.CursorTop = Console.CursorTop + 1;
                Console.CursorLeft = curLeft;
            }
        }

        public static bool SwitchLever(bool i)
        {
            i = !i;
            return i;
        }

        public static bool CheckLeverOnOff(bool i)
        {
            if (i == false)
                LeverOn();
            else
                LeverOff();
            return i;
        }

        public static void CheckLever(string cki)
        {
            switch (cki)
            {
                case "NumPad1":
                case "D1":
                {
                    Lever1 = SwitchLever(Lever1);
                    break;
                }
                case "NumPad2":
                case "D2":
                {
                    Lever2 = SwitchLever(Lever2);
                    break;
                }
                case "NumPad3":
                case "D3":
                {
                    Lever3 = SwitchLever(Lever3);
                    break;
                }
                case "NumPad4":
                case "D4":
                {
                    Lever4 = SwitchLever(Lever4);
                    break;
                }
                case "NumPad5":
                case "D5":
                {
                    Lever5 = SwitchLever(Lever5);
                    break;
                }
                case "NumPad6":
                case "D6":
                {
                    Lever6 = SwitchLever(Lever6);
                    break;
                }
                case "NumPad7":
                case "D7":
                {
                    Lever7 = SwitchLever(Lever7);
                    break;
                }
                case "NumPad8":
                case "D8":
                {
                    Lever8 = SwitchLever(Lever8);
                    break;
                }
                case "NumPad9":
                case "D9":
                {
                    Lever9 = SwitchLever(Lever9);
                    break;
                }
            }
        }
    }
}