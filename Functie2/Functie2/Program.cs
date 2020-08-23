using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functie2
{
    class Program
    {
        public static string strOutput;

        static void Main(string[] args)
        {
            begin:
            Console.WriteLine("kies y/n");
            string strUserInput = Console.ReadLine();
            Console.Clear();
            if (strUserInput == "y")
            {
                strOutput = Program.yes();
            }
            else if (strUserInput == "n")
            {
                strOutput = Program.no();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error, geen geldige invoer ontvangen, type y of n");
                goto begin;
            }
            if (strOutput =="y")
            {
                Console.Clear();
                Console.WriteLine("ggez scrub");
            }
            else if (strOutput =="n")
            {
                goto begin;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error, geen geldige invoer ontvangen, type y of n");
                goto begin;
            }
            Console.ReadLine();
        }
        static string yes()
        {
            Console.WriteLine("je koos net ja, klopt dit? (y/n)");
            strOutput = Console.ReadLine();
            return strOutput;
        }
        static string no()
        {
            Console.WriteLine("je koos net ja, klopt dit? (y/n)");
            strOutput = Console.ReadLine();
            return strOutput;
        }
    }
}
