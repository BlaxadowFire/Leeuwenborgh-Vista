using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Secties
{
    class Program
    {
        static void Main(string[] args)
        {
            string strRestart = string.Empty;
            Console.WriteLine("Do you want to enter this program? y/n");
            string strEnter = Console.ReadLine();
            Console.Clear();
            if (strEnter == "y")
            {
                Console.WriteLine("Are you sure? y/n");
                string strSure = Console.ReadLine();
                if (strSure == "y")
                {
                    Console.WriteLine("Okay, your choice.");
                }
                else
                {
                    Program.Finish();
                }
            }
            else
            {
                Program.Finish();
            }

            do
            {
                Console.Clear();
                Console.WriteLine("Geef uw geboortejaar op");
                int intBirthYear = Convert.ToInt32(Console.ReadLine());
                int intAge = 0;
                int intAgeYoung = 0;
                intAge = 2017 - intBirthYear;
                intAgeYoung = 2016 - intBirthYear;
                if (intBirthYear < 1999 && intBirthYear >= 1899)
                {
                    Console.WriteLine("U bent {1} of {0} jaar oud. U mag alcohol nuttigen, veel plezier!", intAge, intAgeYoung);
                }
                else if (intBirthYear == 1999)
                {
                    Console.WriteLine("Bent u al jarig geweest? y/n");
                    string strBirthCheck = Console.ReadLine();
                    switch (strBirthCheck)
                    {
                        case "y":
                            {
                                Console.WriteLine("U bent {0} jaar oud. U mag alcohol nuttigen, veel plezier!", intAge);
                                break;
                            }
                        case "n":
                            {
                                Console.WriteLine("U bent {0} jaar oud. U mag geen alcohol nuttigen, drink maar iets zonder alcohol!", intAgeYoung);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Error, geef een correcte waarde op.");
                                break;
                            }
                    }

                }
                else if (intBirthYear > 1999)
                {
                    Console.WriteLine("U bent {1} of {0} jaar oud. U mag geen alcohol nuttigen, drink maar iets zonder alcohol!", intAge, intAgeYoung);
                }
                else
                {
                    Console.WriteLine("Error, geef een correcte waarde aan.");
                }
                Console.WriteLine("Wilt u nog een keer kijken? y/n");
                strRestart = Console.ReadLine();
            }
            while (strRestart != "n");

        }
        public static void Finish()
        {
                Console.WriteLine("Oh, okay\r\nPress enter to close.");
                Console.ReadLine();
                Environment.Exit(0);
        }
    }
}
