using System;
using System.IO;

namespace Subwaj
{
    internal class Puzzle4
    {
        public static string[] lever = File.ReadAllLines("files/Puzzles/Puzzle4/lever.txt");
        public static bool Lever1;
        public static bool Lever2;
        public static bool Lever3;
        public static bool Lever4;
        public static bool Lever5;
        public static bool Lever6;
        public static bool Lever7;
        public static bool Lever8;
        public static bool Lever9;

        public static void StartPuzzle4()
        {
            {
                do
                {
                    Console.Clear();
                    Draw();
                    Console.CursorLeft = 0;
                    Program.DrawBottom();
                    var cki = CheckInput();
                    CheckLever(cki);
                } while (!(Lever1 && Lever3 && Lever5 && Lever6 && Lever2 == false && Lever4 == false &&
                           Lever7 == false && Lever8 == false && Lever9 == false));
            }
            Console.Clear();
            Draw();
            Program.BlnPuzzle4Complete = true;
        }

        public static void DrawNumbers()
        {
            Console.SetCursorPosition(12, 8);
            Console.Write("1");
            Console.SetCursorPosition(22, 8);
            Console.Write("2");
            Console.SetCursorPosition(32, 8);
            Console.Write("3");
            Console.SetCursorPosition(42, 8);
            Console.Write("4");
            Console.SetCursorPosition(52, 8);
            Console.Write("5");
            Console.SetCursorPosition(62, 8);
            Console.Write("6");
            Console.SetCursorPosition(72, 8);
            Console.Write("7");
            Console.SetCursorPosition(82, 8);
            Console.Write("8");
            Console.SetCursorPosition(92, 8);
            Console.Write("9");
        }

        public static void Draw()
        {
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
        }

        public static string CheckInput()
        {
            return Console.ReadKey().Key.ToString();
        }

        public static void LeverOn()
        {
            for (var i = 0; i <= 7; i++)
            {
                var CurLeft = Console.CursorLeft;
                Console.Write(lever[i]);
                Console.CursorTop = Console.CursorTop + 1;
                Console.CursorLeft = CurLeft;
            }
        }

        public static void LeverOff()
        {
            for (var i = 8; i <= 16; i++)
            {
                var CurLeft = Console.CursorLeft;
                Console.Write(lever[i]);
                Console.CursorTop = Console.CursorTop + 1;
                Console.CursorLeft = CurLeft;
            }
        }

        public static bool SwitchLever(bool i)
        {
            if (i)
                i = false;
            else
                i = true;
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
                default:
                {
                    break;
                }
            }
        }
    }
}