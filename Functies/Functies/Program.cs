using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functies
{
    class Program
    {
        public static string strUitkomst;

        static void Main(string[] args)
        {
            string strGetal1 = Program.functie1();
            string strGetal2 = Program.functie2();
            Console.Clear();
            Console.WriteLine("Kies wat u wilt doen met de twee getallen.");
            Console.WriteLine("+ - * /");
            string strUserInput = Console.ReadLine();

            int intGetal1 = 0;
            int intGetal2 = 0;
            
            intGetal1 = Convert.ToInt32(strGetal1);
            intGetal2 = Convert.ToInt32(strGetal2);
            Console.Clear();

            string strOutput = Program.functie3(strUserInput, intGetal1, intGetal2, strUitkomst);
            Console.ReadLine();
        }
        static string functie1()
        {
            Console.WriteLine("Voer hier het eerste getal in");
            return Console.ReadLine();
        }
        static string functie2()
        {
            Console.WriteLine("Voer hier het tweede getal in");
            return Console.ReadLine();
        }
        static string functie3(string strUserInput, Int32 intGetal1, Int32 intGetal2, string strUitkomst)
        {
            if (strUserInput == "+")
            {
                Console.WriteLine(intGetal1);
                Console.WriteLine("+");
                Console.WriteLine(intGetal2);
                int intUitkomst = intGetal1 + intGetal2;
                strUitkomst = Convert.ToString(intUitkomst);
            }
            else
            {
                if (strUserInput == "-")
                {
                    Console.WriteLine(intGetal1);
                    Console.WriteLine("-");
                    Console.WriteLine(intGetal2);
                    int intUitkomst = intGetal1 - intGetal2;
                    strUitkomst = Convert.ToString(intUitkomst);
                }
                else
                {
                    if (strUserInput == "*")
                    {
                        Console.WriteLine(intGetal1);
                        Console.WriteLine("*");
                        Console.WriteLine(intGetal2);
                        int intUitkomst = intGetal1 * intGetal2;
                        strUitkomst = Convert.ToString(intUitkomst);
                    }
                    else
                    {
                        if (strUserInput == "/")
                        {
                            Console.WriteLine(intGetal1);
                            Console.WriteLine("/");
                            Console.WriteLine(intGetal2);
                            int intUitkomst = intGetal1 / intGetal2;
                            strUitkomst = Convert.ToString(intUitkomst);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("error: je hebt niet gekozen uit de beschikbare opties.");
                        }
                    }
                }
            }
            return strUitkomst;
        }
    }
}
