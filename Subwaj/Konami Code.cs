using System;
using System.IO;
using System.Threading;

namespace Subwaj
{
    class KonamiCode
    {
        public static void CheckKonami_Code()
        {
            int konamicode = 0;
            Console.Clear();
            Console.WriteLine("Please enter the Konami Code (START = ENTER)");
            do
            {
                Program.Cki = Console.ReadKey();
                string strCki = Program.Cki.Key.ToString();
                switch (strCki)
                {
                    case "UpArrow":
                        {
                            if (konamicode == 0 || konamicode == 1)
                            {
                                konamicode += 1;
                            }
                            else
                            {
                                konamicode = 0;
                            }
                            break;
                        }
                    case "DownArrow":
                        {
                            if (konamicode == 2 || konamicode == 3)
                            {
                                konamicode += 1;
                            }
                            else
                            {
                                konamicode = 0;
                            }
                            break;
                        }
                    case "LeftArrow":
                        {
                            if (konamicode == 4 || konamicode == 6)
                            {
                                konamicode += 1;
                            }
                            else
                            {
                                konamicode = 0;
                            }
                            break;
                        }
                    case "RightArrow":
                        {
                            if (konamicode == 5 || konamicode == 7)
                            {
                                konamicode += 1;
                            }
                            else
                            {
                                konamicode = 0;
                            }
                            break;
                        }
                    case "B":
                        {
                            if (konamicode == 8)
                            {
                                konamicode += 1;
                            }
                            else
                            {
                                konamicode = 0;
                            }
                            break;
                        }
                    case "A":
                        {
                            if (konamicode == 9)
                            {
                                konamicode += 1;
                            }
                            else
                            {
                                konamicode = 0;
                            }
                            break;
                        }
                    case "Enter":
                        {
                            if (konamicode == 10)
                            {
                                string strFilename = "files/Achievements/Konami.txt";
                                Console.WriteLine(File.ReadAllText(strFilename));
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            else
                            {
                                konamicode = 1;
                            }
                            break;
                        }
                    case "Escape":
                        {
                            Program.MainMenu();
                            break;
                        }
                }
            } while (konamicode != 10);
        }
    }
}
