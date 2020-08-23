using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie is de meest awesome persoon die er bestaat\r\n" +
                              "1). Nando \r\n" +
                              "2). Denzel \r\n" +
                              "3). Collin");
            string x = Console.ReadLine();
            if (x == "1")
            {
                Console.WriteLine("Klopt!");
            }
            else if (x == "2")
            {
                Console.WriteLine("Close enough!");
            }
            else if (x == "3")
            {
                Console.WriteLine("Meh");
            }
            else
            {
                Console.WriteLine("Je hebt een onjuiste keuze gegeven.");
            }
            Console.ReadLine();
        }
    }
}
