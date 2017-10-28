using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Subwaj
{
    class Konami_Code
    {
        public Konami_Code() { }
        public static void CheckKonami_Code()
        {
            while (Program.IntCode == 0) ;
            int Konamicode = 0;
            Console.Clear();
            Console.WriteLine("Please enter the Konami Code (START = ENTER)");
            do
            {
                Program.Cki = Console.ReadKey();
                string strCKI = Program.Cki.Key.ToString();
                switch (strCKI)
                {
                    case "UpArrow":
                        {
                            if (Konamicode == 0 || Konamicode == 1)
                            {
                                Konamicode += 1;
                            }
                            else
                            {
                                Konamicode = 0;
                            }
                            break;
                        }
                    case "DownArrow":
                        {
                            if (Konamicode == 2 || Konamicode == 3)
                            {
                                Konamicode += 1;
                            }
                            else
                            {
                                Konamicode = 0;
                            }
                            break;
                        }
                    case "LeftArrow":
                        {
                            if (Konamicode == 4 || Konamicode == 6)
                            {
                                Konamicode += 1;
                            }
                            else
                            {
                                Konamicode = 0;
                            }
                            break;
                        }
                    case "RightArrow":
                        {
                            if (Konamicode == 5 || Konamicode == 7)
                            {
                                Konamicode += 1;
                            }
                            else
                            {
                                Konamicode = 0;
                            }
                            break;
                        }
                    case "B":
                        {
                            if (Konamicode == 8)
                            {
                                Konamicode += 1;
                            }
                            else
                            {
                                Konamicode = 0;
                            }
                            break;
                        }
                    case "A":
                        {
                            if (Konamicode == 9)
                            {
                                Konamicode += 1;
                            }
                            else
                            {
                                Konamicode = 0;
                            }
                            break;
                        }
                    case "Enter":
                        {
                            if (Konamicode == 10)
                            {
                                string strFilename = "files/Achievements/Konami.txt";
                                Console.WriteLine(File.ReadAllText(strFilename));
                                Thread.Sleep(1000);
                                Console.Clear();
                                Program.MainMenu();
                            }
                            else
                            {
                                Konamicode = 0;
                            }
                            break;
                        }
                    case "Escape":
                        {
                            Program.MainMenu();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (true);
        }
    }
}
