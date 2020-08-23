using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _06.Loops
{
    class Program
    {
        public static string strRestart;
        public static string[] strArrEl = {"\\","|","/","--"};
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            for (int intBoot = 0; intBoot <= 3; intBoot++)
            {
                foreach (string el in strArrEl)
                {
                    Console.WriteLine("{0} Made By Nando {0}", el);
                    Thread.Sleep(200);
                    Console.Clear();
                }
            }
            start:
            do
            {

                Console.Clear();
                Console.WriteLine("Geef getal tussen de 0 en de 100");
                string strInput = Console.ReadLine();
                Console.Clear();
                int intInput = Convert.ToInt16(strInput);
                if (intInput <= 100 && intInput >=0)
                {

                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            int intAnswer = i * intInput;
                            Console.WriteLine("{0} x {1} = {2}", i, intInput, intAnswer);
                        }
                    }
                    Console.WriteLine("Wilt u het programma opnieuw uitvoeren? \r\nType y/yes/j/ja, type iets anders om af te sluiten.");
                    Program.strRestart = Console.ReadLine();
                }

                  else
            {
                    Console.WriteLine("Error, vul een getal tussen de 0 en de 100 in.");
                    Thread.Sleep(2000);
                    goto start;
                }
            }
            while (strRestart == "y" || strRestart == "yes" || strRestart == "j" || strRestart == "ja");
        }
    }
}
