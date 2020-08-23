using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace on_a_scale
{
    class Program
    {
        public static string[] strArrEl = { "\\", "|", "/", "--" };
        public static int intLoopCheck = 0;
        static void Main(string[] args)
        {
            
            

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Hello\r\nOn a scale of 1 to Nando, how retarted are you?");
                string strUserInput = Console.ReadLine();
                Console.Clear();
                Program.UserInput(strUserInput);
                if (intLoopCheck == 0)
                {
                    Thread.Sleep(5000);
                }
                Console.Clear();

            }
            while (intLoopCheck == 0);
        }
        static void UserInput(string strUserInput)
        {
          
            switch (strUserInput)
            {
                case "?":
                    {
                        Console.WriteLine("1-10\r\nNando\r\n9000");
                        break;
                    }

                case "1":
                    {
                        Console.WriteLine("Sound like you are lying to me, can't be that good");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Looking good I see");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Cool");
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("hmmm, gotta chill");
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("watch it");
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("you might wanna take a step back");
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("bruh, stop");
                        break;
                    }
                case "8":
                    {
                        Console.WriteLine("CHILL OUT!!");
                        break;
                    }
                case "9":
                    {
                        Console.WriteLine("HOLY SHIT STOP IT");
                        break;
                    }
                case "10":
                    {
                        Console.WriteLine("Since when is 10 on a scale of 1 to Nando?");
                        break;
                    }
                case "Nando":
                    {
                        for (int intX = 0; intX <= 300; intX++)
                        {
                            foreach (string el in strArrEl)
                            {
                                Console.Clear();
                                if (Console.ForegroundColor == ConsoleColor.White)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.Yellow)
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Cyan;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.Black)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.Blue)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.Cyan)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.BackgroundColor = ConsoleColor.DarkGray;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.DarkBlue)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.DarkCyan)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.DarkGray)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.DarkGreen)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.DarkMagenta)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.BackgroundColor = ConsoleColor.Gray;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.DarkRed)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.BackgroundColor = ConsoleColor.Green;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.DarkYellow)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.Gray)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.BackgroundColor = ConsoleColor.Red;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.Green)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.BackgroundColor = ConsoleColor.White;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.Magenta)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                }
                                else if (Console.ForegroundColor == ConsoleColor.Red)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    intLoopCheck = 1;
                                }
                                Console.WriteLine("{0}DAMN SON, YOU JUST WENT FULL RETARD, NEVER, EVER, GO FULL RETARD{0}", el);
                                Console.WriteLine(el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el + el);
                                Thread.Sleep(20);

                            }
                        }
                        intLoopCheck = 1;
                        break;
                    }
                case "over 9000":
                    {
                        Console.WriteLine("Oh haha, you thought there was an easter egg? really?\r\nWell, sux to be you.");
                        break;
                    }
                case "9000":
                    {
                        Console.WriteLine("Oh haha, you thought there was an easter egg? really?\r\nWell, sux to be you.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error, wrong input given");
                        break;
                    }
            }
        }
    }
}
