using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Speech.Synthesis;

namespace Subwaj
{
    class Puzzle3
    {
        public static int Room1 = RandomNumber();
        public static int Room2 = RandomNumber();
        public static int Room3 = RandomNumber();
        public static int Room4 = RandomNumber();
        public Puzzle3() {/*Start methode*/}
        public static string strcki = string.Empty;
        public static int intcki = 0;

        public static string strRoom1 = string.Empty;
        public static string strRoom2 = string.Empty;
        public static string strRoom3 = string.Empty;
        public static string strRoom4 = string.Empty;

        public static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 10);
        }

        public static void StartPuzzle3()
        {
            if (Program.BlnPuzzle3 == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = Program.StrTxtLocation + "Rooms/Room5/Room5.txt";
                string[] IntroText = File.ReadAllLines(strFilename);
                for (int x = 0; x < IntroText.Length; x++)
                {
                    string strIntroText = IntroText[x];
                    Program._SS.SpeakAsync(strIntroText);
                    for (int z = 0; z < strIntroText.Length; z++)
                    {
                        Console.Write(strIntroText[z]);
                        if (strIntroText[z] == ',')
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

            int i = 0;
            int counter = 0;

            do
            {
                i = 0;
                counter = 0;
                strRoom1 = string.Empty;
                strRoom2 = string.Empty;
                strRoom3 = string.Empty;
                strRoom4 = string.Empty;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1 2 3 4");
                    Console.WriteLine("{0} {1} {2} {3}", strRoom1, strRoom2, strRoom3, strRoom4);
                    Program.DrawBottom();
                    strcki = Console.ReadKey().Key.ToString();

                    switch (strcki)
                    {
                        case"D1":
                        case "NumPad1":
                            {
                                intcki = 1;
                                break;
                            }
                        case "D2":
                        case "NumPad2":
                            {
                                intcki = 2;
                                break;
                            }
                        case "D3":
                        case "NumPad3":
                            {
                                intcki = 3;
                                break;
                            }
                        case "D4":
                        case "NumPad4":
                            {
                                intcki = 4;
                                break;
                            }
                        case "D5":
                        case "NumPad5":
                            {
                                intcki = 5;
                                break;
                            }
                        case "D6":
                        case "NumPad6":
                            {
                                intcki = 6;
                                break;
                            }
                        case "D7":
                        case "NumPad7":
                            {
                                intcki = 7;
                                break;
                            }
                        case "D8":
                        case "NumPad8":
                            {
                                intcki = 8;
                                break;
                            }
                        case "D9":
                        case "NumPad9":
                            {
                                intcki = 9;
                                break;
                            }
                        case "D0":
                        case "NumPad0":
                            {
                                intcki = 0;
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
                                intcki = -1;
                                Console.WriteLine("Please give valid input.");
                                Thread.Sleep(1000);
                                break;
                            }
                    }


                    if (i == 0 && intcki == Room2)
                    {
                        i++;
                    }
                    else if (i == 1 && intcki == Room4)
                    {
                        i++;
                    }
                    else if (i == 2 && intcki == Room1)
                    {
                        i++;
                    }
                    else if (i == 3 && intcki == Room3)
                    {
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                    if (intcki != -1)
                    {
                        strcki = Convert.ToString(intcki);
                    }
                    else
                    {
                        strcki = string.Empty;
                    }
                    switch (counter)
                    {
                        case 0:
                            {
                                strRoom1 = strcki;
                                break;
                            }
                        case 1:
                            {
                                strRoom2 = strcki;
                                break;
                            }
                        case 2:
                            {
                                strRoom3 = strcki;
                                break;
                            }
                        case 3:
                            {
                                strRoom4 = strcki;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    if (intcki != -1)
                    {
                        counter++;
                    }
                } while (counter <= 3);
                Console.Clear();
                Console.WriteLine("2 4 1 3");
                Console.WriteLine("{0} {1} {2} {3}", strRoom1, strRoom2, strRoom3, strRoom4);
                Thread.Sleep(250);
            } while (i <= 3);
            Console.WriteLine("Correct!");
            Program.DrawBottom();
            Thread.Sleep(400);
            Console.Clear();
            Program.BlnPuzzle3Complete = true;
            Program.IntKey += 1;
        }
    }
}
