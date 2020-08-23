using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Calculator
{
    class Program
    {
        public static bool blnfirstrun = true;
        static void Main()
        {
            if (blnfirstrun == true)
            {
                ThreadStart ts = new ThreadStart(Bgm);
                Thread BGM = new Thread(ts);
                BGM.Start();
                blnfirstrun = false;
            }


            int intSolution;
            var x = Console.Out.NewLine;
            Console.WriteLine("Welkom bij deze calculator");
            Console.WriteLine("");
            start:
            Console.WriteLine("Vul het eerste getal in");
            int intNumber1 = Convert.ToInt32(Console.ReadLine());
            string strAction = Program.funAction();
            Console.Clear();
            Console.WriteLine("Vul het 2e getal in");
            int intNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            UserCheck:
            Console.WriteLine("De som is{0} {1} {2}, is dit correct?", intNumber1, strAction, intNumber2);
            string strUserCheck = Console.ReadLine();
            if (strUserCheck == "yes" || strUserCheck == "y" || strUserCheck == "ja" || strUserCheck == "j")
            {
               intSolution = Program.funCalc(intNumber1, strAction, intNumber2);
            }
            else if (strUserCheck == "no" || strUserCheck == "n" || strUserCheck == "nee" || strUserCheck == "n")
            {
                goto start;
            }
            else
            {
                Console.WriteLine("error, give valid input");
                goto UserCheck;
            }
            Console.WriteLine("{0}{1}{2} = {3}",intNumber1, strAction, intNumber2, intSolution);
            Console.ReadLine();
            Program.Main();


        }

        public static void Bgm()
        {
            do
            {
                Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 1000);
                Console.Beep(659, 500);
                Console.Beep(659, 500);
                Console.Beep(659, 500);
                Console.Beep(698, 350);
                Console.Beep(523, 150);
                Console.Beep(415, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 1000);
            }
            while (true);
        }


        static int funCalc(int intNumber1, string strAction, int intNumber2)
        {
            int intSolution = 0;
            if (strAction == "/")
            {
                intSolution = intNumber1 / intNumber2;
                return intSolution;
            }
            else if (strAction == "*")
            {
                intSolution = intNumber1 * intNumber2;
                return intSolution;
            }
            else if (strAction == "+")
            {
                intSolution = intNumber1 + intNumber2;
                return intSolution;
            }
            else if (strAction == "-")
            {
                intSolution = intNumber1 - intNumber2;
                return intSolution;
            }
            else
            {
                Console.WriteLine(" something went wrong \r\nDruk op enter om door te gaan.");
                return intSolution;
            }
        }
        static string funAction()
        {
            Action:
            Console.Clear();
            Console.WriteLine("Vul de actie in");
            Console.WriteLine("Kies uit: \r\n / \r\n * \r\n - \r\n +");
            string strAction = Console.ReadLine();
            if (strAction == "/" || strAction == "*" || strAction == "-" || strAction == "+")
            {
                return strAction;
            }
            else
            {
                Console.WriteLine("error, wrong input");
                Console.ReadLine();
                goto Action;
            }
        }
    }
}
