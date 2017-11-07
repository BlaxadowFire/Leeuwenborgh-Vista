using System;
using System.Threading;
using System.IO;

namespace Subwaj
{
    class Puzzle3
    {
        public static Random RandomNumber = new Random();
        public static int Room1 = RandomNumbers();
        public static int Room2 = RandomNumbers();
        public static int Room3 = RandomNumbers();
        public static int Room4 = RandomNumbers();

        public static int RandomNumbers()
        {
            loop:
            int intRandomNumber = RandomNumber.Next(0,10);
            if (intRandomNumber == Room1 || intRandomNumber == Room2 || intRandomNumber == Room3 || intRandomNumber == Room4)
            {
                goto loop;
            }
            return intRandomNumber ;
        }

        public static string Strcki = string.Empty;
        public static int Intcki;

        public static string StrRoom1 = string.Empty;
        public static string StrRoom2 = string.Empty;
        public static string StrRoom3 = string.Empty;
        public static string StrRoom4 = string.Empty;


        //Creating a random number for puzzle 3

        public static void StartPuzzle3()
        {
            if (Program.BlnPuzzle3 == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = Program.StrTxtLocation + "Rooms/Room5/Room5.txt";
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
                Program.BlnPuzzle3 = true;
            }

            int i;

            do
            {
                i = 0;
                var counter = 0;
                StrRoom1 = string.Empty;
                StrRoom2 = string.Empty;
                StrRoom3 = string.Empty;
                StrRoom4 = string.Empty;
                do
                {
                    Console.Clear();
                    Console.WriteLine("2 4 1 3");
                    Console.WriteLine("{0} {1} {2} {3}", StrRoom1, StrRoom2, StrRoom3, StrRoom4);
                    Program.DrawBottom();
                    Strcki = Console.ReadKey().Key.ToString();

                    switch (Strcki)
                    {
                        case"D1":
                        case "NumPad1":
                            {
                                Intcki = 1;
                                break;
                            }
                        case "D2":
                        case "NumPad2":
                            {
                                Intcki = 2;
                                break;
                            }
                        case "D3":
                        case "NumPad3":
                            {
                                Intcki = 3;
                                break;
                            }
                        case "D4":
                        case "NumPad4":
                            {
                                Intcki = 4;
                                break;
                            }
                        case "D5":
                        case "NumPad5":
                            {
                                Intcki = 5;
                                break;
                            }
                        case "D6":
                        case "NumPad6":
                            {
                                Intcki = 6;
                                break;
                            }
                        case "D7":
                        case "NumPad7":
                            {
                                Intcki = 7;
                                break;
                            }
                        case "D8":
                        case "NumPad8":
                            {
                                Intcki = 8;
                                break;
                            }
                        case "D9":
                        case "NumPad9":
                            {
                                Intcki = 9;
                                break;
                            }
                        case "D0":
                        case "NumPad0":
                            {
                                Intcki = 0;
                                break;
                            }
                        case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Intcki = -1;
                                Console.WriteLine("Please give valid input.");
                                Thread.Sleep(1000);
                                break;
                            }
                    }


                    if (i == 0 && Intcki == Room2)
                    {
                        i++;
                    }
                    else if (i == 1 && Intcki == Room4)
                    {
                        i++;
                    }
                    else if (i == 2 && Intcki == Room1)
                    {
                        i++;
                    }
                    else if (i == 3 && Intcki == Room3)
                    {
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                    Strcki = Intcki != -1 ? Convert.ToString(Intcki) : string.Empty;
                    switch (counter)
                    {
                        case 0:
                            {
                                StrRoom1 = Strcki;
                                break;
                            }
                        case 1:
                            {
                                StrRoom2 = Strcki;
                                break;
                            }
                        case 2:
                            {
                                StrRoom3 = Strcki;
                                break;
                            }
                        case 3:
                            {
                                StrRoom4 = Strcki;
                                break;
                            }
                    }
                    if (Intcki != -1)
                    {
                        counter++;
                    }
                } while (counter <= 3);
                Console.Clear();
                Console.WriteLine("2 4 1 3");
                Console.WriteLine("{0} {1} {2} {3}", StrRoom1, StrRoom2, StrRoom3, StrRoom4);
                Thread.Sleep(250);
            } while (i <= 3);
            Console.WriteLine("Correct!");
            Console.WriteLine("congratulations, you earned the key");
            Program.Ss.Speak("congratulations, you earned the key");
            Program.DrawBottom();
            Thread.Sleep(1000);
            Console.Clear();
            Program.BlnPuzzle3Complete = true;
            Program.IntKey += 1;
        }
    }
}
